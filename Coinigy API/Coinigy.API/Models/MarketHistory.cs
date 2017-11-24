using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class MarketHistory
    {
        [DeserializeAs(Name = "price")]
        public string Price { get; set; }

        [DeserializeAs(Name = "quantity")]
        public string Quantity { get; set; }

        [DeserializeAs(Name = "time_local")]
        public string TimeLocal { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }
    }
}
