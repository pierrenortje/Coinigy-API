using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddAlertModel
    {
        [SerializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [SerializeAs(Name = "market_name")]
        public string MarketName { get; set; }

        [SerializeAs(Name = "alert_price")]
        public double AlertPrice { get; set; }

        [SerializeAs(Name = "alert_note")]
        public string AlertNote { get; set; }
    }
}
