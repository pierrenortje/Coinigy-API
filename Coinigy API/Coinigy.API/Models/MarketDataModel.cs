using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class MarketDataModel
    {
        [SerializeAs(Name = "exchange_code")]
        public string ExchangeCode { get; set; }

        [SerializeAs(Name = "exchange_market")]
        public string ExchangeMarket { get; set; }

        [SerializeAs(Name = "type")]
        public string Type { get; set; }
    }
}
