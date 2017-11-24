using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class OrderType
    {
        [DeserializeAs(Name = "order_types")]
        public List<OrderTypeItem> OrderTypes { get; set; }

        [DeserializeAs(Name = "price_types")]
        public List<PriceType> PriceTypes { get; set; }
    }
}
