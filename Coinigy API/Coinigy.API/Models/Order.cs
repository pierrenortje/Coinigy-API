using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class Order
    {
        [DeserializeAs(Name = "open_orders")]
        public List<OpenOrder> OpenOrders { get; set; }

        [DeserializeAs(Name = "order_history")]
        public List<OrderHistory> OrderHistory { get; set; }
    }
}
