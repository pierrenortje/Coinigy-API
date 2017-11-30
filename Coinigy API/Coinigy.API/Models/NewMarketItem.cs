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

using Newtonsoft.Json;

namespace Coinigy.API.Models
{
    public class NewMarketItem
    {
        [JsonProperty("orders_channel_name")]
        public object OrdersChannelName { get; set; }

        [JsonProperty("history_channel_name")]
        public object HistoryChannelName { get; set; }

        [JsonProperty("exchmkt_id")]
        public long ExchmktId { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("high")]
        public long High { get; set; }

        [JsonProperty("market_id")]
        public long MarketId { get; set; }

        [JsonProperty("low")]
        public long Low { get; set; }

        [JsonProperty("mkt_name")]
        public string MktName { get; set; }

        [JsonProperty("request_pair")]
        public object RequestPair { get; set; }

        [JsonProperty("primary_code")]
        public string PrimaryCode { get; set; }

        [JsonProperty("price")]
        public long Price { get; set; }

        [JsonProperty("primary_name")]
        public string PrimaryName { get; set; }

        [JsonProperty("secondary_name")]
        public string SecondaryName { get; set; }

        [JsonProperty("secondary_code")]
        public string SecondaryCode { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }
    }
}
