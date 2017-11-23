using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class OpenAlert
    {
        public string exch_name { get; set; }
        public string mkt_name { get; set; }
        public string price { get; set; }
        public string @operator { get; set; }
        public string alert_id { get; set; }
        public string operator_text { get; set; }
        public string alert_note { get; set; }
        public string alert_added { get; set; }
        public string display_name { get; set; }
        public string exch_code { get; set; }
    }

    public class AlertHistory
    {
        public string exch_name { get; set; }
        public string mkt_name { get; set; }
        public string price { get; set; }
        public string @operator { get; set; }
        public string alert_history_id { get; set; }
        public string timestamp { get; set; }
        public string alert_price { get; set; }
        public string operator_text { get; set; }
        public string alert_note { get; set; }
        public string display_name { get; set; }
    }

    public class Alert
    {
        public List<OpenAlert> open_alerts { get; set; }
        public List<AlertHistory> alert_history { get; set; }
    }
}
