using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class MarketAsk
    {
        [DeserializeAs(Name = "price")]
        public string Price { get; set; }

        [DeserializeAs(Name = "quantity")]
        public string Quantity { get; set; }

        [DeserializeAs(Name = "total")]
        public string Total { get; set; }
    }
}
