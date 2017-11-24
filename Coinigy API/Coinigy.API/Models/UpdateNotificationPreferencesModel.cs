using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class UpdateNotificationPreferencesModel
    {
        [SerializeAs(Name = "alert_email")]
        public int AlertEmail { get; set; }

        [SerializeAs(Name = "alert_sms")]
        public int AlertSms { get; set; }

        [SerializeAs(Name = "trade_email")]
        public int TradeEmail { get; set; }

        [SerializeAs(Name = "trade_sms")]
        public int TradeSms { get; set; }

        [SerializeAs(Name = "balance_email")]
        public int BalanceEmail { get; set; }
    }
}
