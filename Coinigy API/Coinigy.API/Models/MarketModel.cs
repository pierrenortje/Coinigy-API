using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class MarketModel
    {
        [SerializeAs(Name = "exchange_code")]
        public string ExchangeCode { get; set; }
    }
}
