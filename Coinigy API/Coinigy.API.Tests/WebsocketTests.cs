using Coinigy.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Threading;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class WebsocketTests : TestBase
    {
        private static readonly ManualResetEvent resetEvent = new ManualResetEvent(false);
        private static Websocket socket;

        [TestMethod]
        public void Subscribe_And_Listen()
        {
            socket = new Websocket(new ApiCredentials
            {
                ApiKey = TestBase.ApiKey,
                ApiSecret = TestBase.ApiSecret
            });

            socket.OnClientReady += Socket_OnClientReady;
            socket.OnClosed += Socket_OnClosed;
            socket.OnError += Socket_OnError;
            socket.OnFatality += Socket_OnFatality;
            socket.OnOrderMessage += Socket_OnOrderMessage;
            socket.OnSendFailed += Socket_OnSendFailed;
            socket.OnStateChanged += Socket_OnStateChanged;
            socket.OnTradeMessage += Socket_OnTradeMessage;

            //socket.OnBlockMessage += Socket_OnBlockMessage;
            //socket.OnChannelsResponse += Socket_OnChannelsResponse;
            //socket.OnExchangesResponse += Socket_OnExchangesResponse;
            //socket.OnFavoriteMessage += Socket_OnFavoriteMessage;
            //socket.OnMessage += Socket_OnMessage;
            //socket.OnNewMarketMessage += Socket_OnNewMarketMessage;
            //socket.OnNewsMessage += Socket_OnNewsMessage;
            //socket.OnNotificationMessage += Socket_OnNotificationMessage;

            socket.Connect();

            resetEvent.WaitOne();
        }

        #region Private Methods
        private void WriteLog(string message)
        {
            Debug.WriteLine($"{DateTime.UtcNow}: {message}");
        }
        #endregion

        #region Private Events
        private void Socket_OnTradeMessage(string exchange, string primaryCurrency, string secondaryCurrency, Models.TradeItem trade)
        {
            WriteLog($"Received new trade for {exchange} market {primaryCurrency}/{secondaryCurrency} price {trade.Price}");
        }

        private void Socket_OnStateChanged(System.Net.WebSockets.WebSocketState newState, System.Net.WebSockets.WebSocketState prevState)
        {
            WriteLog($"Socket state changed from {prevState} to {newState}.");
        }

        private void Socket_OnSendFailed(string data, System.Exception ex)
        {
            WriteLog($"Sending failed. Message: {ex.Message}");
        }

        private void Socket_OnOrderMessage(string exchange, string curr1, string curr2, System.Collections.Generic.List<OrderItem> orders)
        {
            WriteLog($"Received new order for {exchange} market {curr1}/{curr2}. Total orders: {orders.Count}");
        }

        private void Socket_OnNotificationMessage(NotificationDataItem notification)
        {
            WriteLog($"Received notification: {notification.Message}");
        }

        private void Socket_OnNewsMessage(NewsDataItem news)
        {
            WriteLog($"Received news item \"{news.Title}\"");
        }

        private void Socket_OnNewMarketMessage(NewMarketDataItem markets)
        {
            WriteLog($"Total New Markets: {markets.Markets.Count}");
        }

        private void Socket_OnMessage(Types.MessageType messageType, string data)
        {

        }

        private void Socket_OnFavoriteMessage(System.Collections.Generic.List<Models.FavoriteDataItem> favorites)
        {
            WriteLog($"Total Favourites: {favorites.Count}");
        }

        private void Socket_OnFatality(string reason)
        {
            WriteLog($"Fatality: {reason}");
        }

        private void Socket_OnExchangesResponse(System.Collections.Generic.List<Models.ExchangeItem> exchanges)
        {
            
        }

        private void Socket_OnError(System.Exception ex)
        {
            WriteLog($"Error: {ex.Message}");
        }

        private void Socket_OnClosed(System.Net.WebSockets.WebSocketCloseStatus reason)
        {
            WriteLog($"Closed: {reason.ToString()}");
        }

        private void Socket_OnClientReady()
        {
            socket.SubscribeToTradeChannel("BMEX", "XBT", "USD");
            socket.SubscribeToTradeChannel("BTCE", "NMC", "USD");
        }

        private void Socket_OnChannelsResponse(System.Collections.Generic.List<string> channels)
        {
            
        }

        private void Socket_OnBlockMessage(string currency, Models.BlockItem block)
        {
            
        }
        #endregion
    }
}
