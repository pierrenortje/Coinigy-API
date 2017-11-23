using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddAlertModel
    {
        [SerializeAs(Name = "exch_code")]
        public string exch_code { get; set; }
        public string market_name { get; set; }
        public double alert_price { get; set; }
        public string alert_note { get; set; }
    }
}
