using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateNotificationPreferencesModel
    {
        [SerializeAs(Name = "alert_email")]
        public int alert_email { get; set; }
        public int alert_sms { get; set; }
        public int trade_email { get; set; }
        public int trade_sms { get; set; }
        public int balance_email { get; set; }
    }
}
