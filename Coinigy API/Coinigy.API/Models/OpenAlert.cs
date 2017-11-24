using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class OpenAlert
    {
        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "mkt_name")]
        public string MktName { get; set; }

        [DeserializeAs(Name = "price")]
        public string Price { get; set; }

        [DeserializeAs(Name = "operator")]
        public string Operator { get; set; }

        [DeserializeAs(Name = "alert_id")]
        public string AlertId { get; set; }

        [DeserializeAs(Name = "operator_text")]
        public string OperatorText { get; set; }

        [DeserializeAs(Name = "alert_note")]
        public string AlertNote { get; set; }

        [DeserializeAs(Name = "alert_added")]
        public string AlertAdded { get; set; }

        [DeserializeAs(Name = "display_name")]
        public string DisplayName { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }
    }
}
