using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class OrderTypeItem
    {
        public string order_type_id { get; set; }
        public string name { get; set; }
        public string order { get; set; }
    }

    public class PriceType
    {
        public string price_type_id { get; set; }
        public string name { get; set; }
        public string order { get; set; }
    }

    public class OrderType
    {
        [DeserializeAs(Name = "order_types")]
        public List<OrderTypeItem> OrderTypes { get; set; }
        public List<PriceType> price_types { get; set; }
    }
}
