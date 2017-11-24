using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class Alert
    {
        [DeserializeAs(Name = "open_alerts")]
        public List<OpenAlert> OpenAlerts { get; set; }

        [DeserializeAs(Name = "alert_history")]
        public List<AlertHistory> AlertHistory { get; set; }
    }
}
