using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class MarketDataModel
    {
        [SerializeAs(Name = "exchange_code")]
        public string exchange_code { get; set; }
        public string exchange_market { get; set; }
        public string type { get; set; }
    }
}
