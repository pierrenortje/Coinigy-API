using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class OpenOrder
    {
        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "mkt_name")]
        public string MktName { get; set; }

        [DeserializeAs(Name = "limit_price")]
        public string LimitPrice { get; set; }

        [DeserializeAs(Name = "operator")]
        public string Operator { get; set; }

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

        [DeserializeAs(Name = "order_time")]
        public string OrderTime { get; set; }

        [DeserializeAs(Name = "foreign_order_id")]
        public string ForeignOrderId { get; set; }

        [DeserializeAs(Name = "auth_nickname")]
        public string AuthNickname { get; set; }

        [DeserializeAs(Name = "auth_id")]
        public string AuthId { get; set; }

        [DeserializeAs(Name = "quantity_remaining")]
        public string Quantity_remaining { get; set; }

        [DeserializeAs(Name = "stop_price")]
        public string StopPrice { get; set; }

        [DeserializeAs(Name = "price_type_id")]
        public string PriceTypeId { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "display_name")]
        public string DisplayName { get; set; }
    }

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

    public class Order
    {
        [DeserializeAs(Name = "open_orders")]
        public List<OpenOrder> Openorders { get; set; }

        [DeserializeAs(Name = "order_history")]
        public List<OrderHistory> Orderhistory { get; set; }
    }
}
