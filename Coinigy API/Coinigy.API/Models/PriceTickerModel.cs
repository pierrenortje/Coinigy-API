using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class PriceTickerModel
    {
        [SerializeAs(Name = "exchange_code")]
        public string ExchangeCode { get; set; }

        [SerializeAs(Name = "exchange_market")]
        public string ExchangeMarket { get; set; }
    }
}
