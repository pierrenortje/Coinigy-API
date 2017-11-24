﻿#region License
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

using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class OrderHistory
    {
        [DeserializeAs(Name = "exch_id")]
        public string ExchId { get; set; }

        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "mkt_name")]
        public string MktName { get; set; }

        [DeserializeAs(Name = "auth_id")]
        public string AuthId { get; set; }

        [DeserializeAs(Name = "executed_price")]
        public string ExecutedPrice { get; set; }

        [DeserializeAs(Name = "limit_price")]
        public string LimitPrice { get; set; }

        [DeserializeAs(Name = "order_id")]
        public string OrderId { get; set; }

        [DeserializeAs(Name = "order_type")]
        public string OrderType { get; set; }

        [DeserializeAs(Name = "order_price_type")]
        public string OrderPriceType { get; set; }

        [DeserializeAs(Name = "order_status")]
        public string OrderStatus { get; set; }

        [DeserializeAs(Name = "quantity")]
        public string Quantity { get; set; }

        [DeserializeAs(Name = "quantity_remaining")]
        public string QuantityRemaining { get; set; }

        [DeserializeAs(Name = "last_updated")]
        public string LastUpdated { get; set; }

        [DeserializeAs(Name = "order_time")]
        public string OrderTime { get; set; }

        [DeserializeAs(Name = "auth_nickname")]
        public string AuthNickname { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "display_name")]
        public string DisplayName { get; set; }

        [DeserializeAs(Name = "unixtime")]
        public string Unixtime { get; set; }
    }
}
