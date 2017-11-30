#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

using Coinigy.API.Models;
using Coinigy.API.Types;
using Coinigy.API.Util;
using Newtonsoft.Json.Linq;
using PureSocketCluster;
using PureWebSockets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text.RegularExpressions;

namespace Coinigy.API
{
    public class Websocket
    {
        #region Private Fields
        private readonly List<KeyValuePair<string, Message>> channelCallbacks = new List<KeyValuePair<string, Message>>();
        private readonly PureSocketClusterSocket socket;
        private readonly ApiCredentials credentials;

        private const string PUBLISH_REGEX = @"^{""event""*.:*.""#publish""";
        private bool isAuthorized;
        #endregion

        #region Constructor
        public Websocket(ApiCredentials credentials)
        {
            this.credentials = credentials;

            this.socket = new PureSocketClusterSocket("wss://sc-02.coinigy.com/socketcluster/");

            InitializeEvents();
        }
        #endregion

        #region Public Events
        public event ClientIsReady OnClientReady;
        public event StateChanged OnStateChanged;
        public event Closed OnClosed;
        public event Error OnError;
        public event Fatality OnFatality;
        public event SendFailed OnSendFailed;
        public event OrderMessage OnOrderMessage;
        public event TradeMessage OnTradeMessage;
        public event BlockMessage OnBlockMessage;
        public event FavoriteMessage OnFavoriteMessage;
        public event NewMarketMessage OnNewMarketMessage;
        public event NotificationMessage OnNotificationMessage;
        public event NewsMessage OnNewsMessage;
        public event Message OnMessage;
        #endregion

        #region Public Delegates
        public delegate void Channels(List<string> channels);
        public delegate void Exchanges(List<ExchangeItem> exchanges);
        public delegate void ClientIsReady();
        public delegate void Message(MessageType messageType, string data);
        public delegate void TradeMessage(string exchange, string curr1, string curr2, TradeItem trade);
        public delegate void OrderMessage(string exchange, string curr1, string curr2, List<OrderItem> orders);
        public delegate void BlockMessage(string currency, BlockItem block);
        public delegate void FavoriteMessage(List<FavoriteDataItem> favorites);
        public delegate void NewMarketMessage(NewMarketDataItem markets);
        public delegate void NotificationMessage(NotificationDataItem notification);
        public delegate void NewsMessage(NewsDataItem news);
        #endregion

        #region Public Methods
        public bool Connect()
        {
            Validate();

            return this.socket.Connect();
        }

        public void SelectChannels(Channels channels, string exchangeCode = "")
        {
            var channelList = new List<string>();

            Validate();

            this.socket.Emit("channels", exchangeCode, ack: (string name, object error, object data) =>
            {
                var dataList = (JArray)data;
                foreach (var dataItem in dataList)
                    foreach (var item in dataItem)
                        try
                        {
                            channelList.Add(item?.ElementAt(0)?.Children().ElementAt(0)?.ToString());
                        }
                        catch { }

                #region Remove Depricated
                if (channelList.Contains("TICKER"))
                    channelList.Remove("TICKER");
                if (channelList.Contains("CHATMSG"))
                    channelList.Remove("CHATMSG");
                if (channelList.Contains("NOTIFICATION"))
                    channelList.Remove("NOTIFICATION");
                #endregion

                channels.Invoke(channelList);
            });
        }
        public void SelectExchanges(Exchanges exchanges)
        {
            var exchangeList = new List<ExchangeItem>();

            Validate();

            this.socket.Emit("exchanges", string.Empty, ack: (string name, object error, object data) =>
            {
                var dataList = (JArray)data;
                foreach (var dataItem in dataList)
                    foreach (var item in dataItem)
                        try
                        {
                            exchangeList.Add(Helper.ToEntity<ExchangeItem>(item.ToString()));
                        }
                        catch { }

                exchanges.Invoke(exchangeList);
            });
        }

        public bool SubscribeToChannel(string channelName) => socket.Subscribe(channelName);

        public bool SubscribeToTradeChannel(string exchange, string primaryCurrency, string secondaryCurrency) => socket.Subscribe($"TRADE-{exchange}--{primaryCurrency}--{secondaryCurrency}");
        public bool SubscribeToOrderChannel(string exchange, string primaryCurrency, string secondaryCurrency) => socket.Subscribe($"ORDER-{exchange}--{primaryCurrency}--{secondaryCurrency}");
        public bool SubscribeToNewsChannel() => socket.Subscribe("NEWS");
        public bool SubscribeToBlockChannel(string currency) => socket.Subscribe($"BLOCK-{currency}");
        public bool SubscribeToNewMarketChannel() => socket.Subscribe("NEWMARKET");
        public bool SubscribeToChannel(string channelName, Message callback)
        {
            this.channelCallbacks.Add(new KeyValuePair<string, Message>(channelName, callback));

            return socket.Subscribe(channelName);
        }
        #endregion

        #region Private Methods
        private void On_Opened()
        {
            socket.Emit("auth", credentials, ack: (string name, object error, object data) =>
            {
                isAuthorized = true;

                OnClientReady?.Invoke();
            });
        }

        private void On_SendFailed(string data, Exception ex) => OnSendFailed?.Invoke(data, ex);

        private void On_Fatality(string reason) => OnFatality?.Invoke(reason);

        private void On_Error(Exception ex) => OnError?.Invoke(ex);

        private void On_Closed(WebSocketCloseStatus reason) => OnClosed?.Invoke(reason);

        private void On_StateChanged(WebSocketState newState, WebSocketState prevState) => OnStateChanged?.Invoke(newState, prevState);

        private void On_Message(string message)
        {
            var m = Regex.Match(message, PUBLISH_REGEX);
            if (!m.Success) return;

            var jObj = JObject.Parse(message);

            string channelName = jObj["data"]["channel"].ToString();

            string requestType = GetRequestType(jObj);
            if (string.IsNullOrEmpty(requestType))
                return;

            InvokeSubscriberCallbacks(channelName, requestType, message);

            InvokeMessageReceived(channelName, requestType, message);
        }

        private void InitializeEvents()
        {
            this.socket.OnOpened += On_Opened;
            this.socket.OnMessage += On_Message;
            this.socket.OnStateChanged += On_StateChanged;
            this.socket.OnClosed += On_Closed;
            this.socket.OnError += OnError;
            this.socket.OnFatality += On_Fatality;
            this.socket.OnSendFailed += On_SendFailed;
        }

        private void InvokeSubscriberCallbacks(string channelName, string requestType, string message)
        {
            var callbacks = channelCallbacks.Where(c => c.Key.Equals(channelName, StringComparison.OrdinalIgnoreCase));
            foreach (var callback in callbacks)
                callback.Value.Invoke(GetMessageType(requestType), message);
        }

        private void InvokeMessageReceived(string channelName, string requestType, string message)
        {
            MessageType messageType = GetMessageType(requestType);
            switch (messageType)
            {
                case MessageType.OrderData:
                    var orderMarketInfo = MarketInfo.ParseMarketInfo(channelName);
                    var orders = Helper.ToEntity<OrderResponse>(message);

                    OnOrderMessage?.Invoke(orderMarketInfo.Exchange, orderMarketInfo.Curr1, orderMarketInfo.Curr2, orders.OrderData.Orders);
                    break;
                case MessageType.TradeData:
                    var tradeMarketInfo = MarketInfo.ParseMarketInfo(channelName);
                    var trade = Helper.ToEntity<TradeResponse>(message);

                    OnTradeMessage?.Invoke(tradeMarketInfo.Exchange, tradeMarketInfo.Curr1, tradeMarketInfo.Curr2, trade.TradeData.Trade);
                    break;
                case MessageType.BlockData:
                    var blockInfo = BlockItem.ParseBlockInfo(channelName);

                    OnBlockMessage?.Invoke(blockInfo, new BlockItem());
                    break;
                case MessageType.FavoriteData:
                    var favourites = Helper.ToEntity<FavoriteResponse>(message);

                    OnFavoriteMessage?.Invoke(favourites.Data.FavoritesDataData.Favorites);
                    break;
                case MessageType.NotificationData:
                    var notification = Helper.ToEntity<NotificationResponse>(message);

                    OnNotificationMessage?.Invoke(notification.NotificationData.NotificationDataData.NotificationDataItem);
                    break;
                case MessageType.NewsData:
                    var news = Helper.ToEntity<NewsResponse>(message);

                    OnNewsMessage?.Invoke(news.NewsData.NewsDataItem);
                    break;
                case MessageType.NewMarket:
                    var newMarket = Helper.ToEntity<NewMarketResponse>(message);

                    OnNewMarketMessage?.Invoke(newMarket.NewMarketData.NewMarketDataItem);
                    break;
            }

            OnMessage?.Invoke(messageType, message);
        }

        private void Validate()
        {
            if (this.socket == null)
                throw new NullReferenceException("The socket has failed to be initialized.");

            if (this.socket.SocketState != WebSocketState.Open)
                throw new Exception("The socket has not been opened.");

            if (!this.isAuthorized)
                throw new UnauthorizedAccessException("You have not been authorized yet. Please subscribe to the OnClientReady event and wait for authorization.");
        }
        #endregion

        #region Private Static Methods
        private static MessageType GetMessageType(string requestType)
        {
            switch (requestType.ToUpper())
            {
                case "ORDER":
                    return MessageType.OrderData;
                case "TRADE":
                    return MessageType.TradeData;
                case "BLOCK":
                    return MessageType.BlockData;
                case "FAVORITE":
                    return MessageType.FavoriteData;
                case "NOTIFICATION":
                    return MessageType.NotificationData;
                case "NEWS":
                    return MessageType.NewsData;
                case "NEWMARKET":
                    return MessageType.NewMarket;
                default:
                    return MessageType.Unknown;
            }
        }

        private static string GetRequestType(JObject jObj)
        {
            string requestType = string.Empty;
            var channelName = jObj["data"]["channel"].ToString();

            Guid guid;
            if (!Guid.TryParse(channelName, out guid))
                return channelName.Substring(0, channelName.IndexOf('-'));

            Guid channelGuid;
            requestType = channelName;
            if (Guid.TryParse(channelName, out channelGuid))
                if (channelGuid.ToString().ToLower() == channelName.ToLower())
                    requestType = jObj["data"]["data"]["MessageType"].ToString();

            return requestType;
        }
        #endregion
    }
}
