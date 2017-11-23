namespace Coinigy.API.Models
{
    public class AccountInfo
    {
        public string email { get; set; }
        public string active { get; set; }
        public string last_login { get; set; }
        public string chat_enabled { get; set; }
        public string chat_nick { get; set; }
        public string ticker_enabled { get; set; }
        public string ticker_indicator_time_type { get; set; }
        public string custom_ticker { get; set; }
        public object first_name { get; set; }
        public object last_name { get; set; }
        public string last_active { get; set; }
        public string pref_subscription_expires { get; set; }
        public string pref_alert_email { get; set; }
        public string pref_alert_sms { get; set; }
        public string pref_trade_email { get; set; }
        public string pref_trade_sms { get; set; }
        public object pref_alert_mobile { get; set; }
        public object pref_trade_mobile { get; set; }
        public string pref_balance_email { get; set; }
        public string pref_referral_code { get; set; }
        public string created_on { get; set; }
        public object company { get; set; }
        public object phone { get; set; }
        public object street1 { get; set; }
        public object street2 { get; set; }
        public object city { get; set; }
        public object state { get; set; }
        public object zip { get; set; }
        public object country { get; set; }
        public string newsletter { get; set; }
        public string two_factor { get; set; }
        public string subscription_status { get; set; }
        public string referral_balance { get; set; }
        public bool pref_app_device_id { get; set; }
    }
}
