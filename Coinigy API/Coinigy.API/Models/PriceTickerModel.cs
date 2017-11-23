using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class PriceTickerModel
    {
        [SerializeAs(Name = "exchange_code")]
        public string exchange_code { get; set; }

        [SerializeAs(Name = "exchange_market")]
        public string exchange_market { get; set; }
    }
}
