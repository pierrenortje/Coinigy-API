#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion


using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class AccountInfo
    {
        [DeserializeAs(Name = "email")]
        public string Email { get; set; }

        [DeserializeAs(Name = "active")]
        public string Active { get; set; }

        [DeserializeAs(Name = "last_login")]
        public string LastLogin { get; set; }

        [DeserializeAs(Name = "chat_enabled")]
        public string ChatEnabled { get; set; }

        [DeserializeAs(Name = "chat_nick")]
        public string ChatNick { get; set; }

        [DeserializeAs(Name = "ticker_enabled")]
        public string TickerEnabled { get; set; }

        [DeserializeAs(Name = "ticker_indicator_time_type")]
        public string TickerIndicatorTimeType { get; set; }

        [DeserializeAs(Name = "custom_ticker")]
        public string CustomTicker { get; set; }

        [DeserializeAs(Name = "first_name")]
        public object FirstName { get; set; }

        [DeserializeAs(Name = "last_name")]
        public object LastName { get; set; }

        [DeserializeAs(Name = "last_active")]
        public string LastActive { get; set; }

        [DeserializeAs(Name = "pref_subscription_expires")]
        public string PrefSubscriptionExpires { get; set; }

        [DeserializeAs(Name = "pref_alert_email")]
        public string PrefAlertEmail { get; set; }

        [DeserializeAs(Name = "pref_alert_sms")]
        public string PrefAlertSms { get; set; }

        [DeserializeAs(Name = "pref_trade_email")]
        public string PrefTradeEmail { get; set; }

        [DeserializeAs(Name = "pref_trade_sms")]
        public string PrefTradeSms { get; set; }

        [DeserializeAs(Name = "pref_alert_mobile")]
        public object PrefAlertMobile { get; set; }

        [DeserializeAs(Name = "pref_trade_mobile")]
        public object PrefTradeMobile { get; set; }

        [DeserializeAs(Name = "pref_balance_email")]
        public string PrefBalanceEmail { get; set; }

        [DeserializeAs(Name = "pref_referral_code")]
        public string PrefReferralCode { get; set; }

        [DeserializeAs(Name = "created_on")]
        public string CreatedOn { get; set; }

        [DeserializeAs(Name = "company")]
        public object Company { get; set; }

        [DeserializeAs(Name = "phone")]
        public object Phone { get; set; }

        [DeserializeAs(Name = "street1")]
        public object Street1 { get; set; }

        [DeserializeAs(Name = "street2")]
        public object Street2 { get; set; }

        [DeserializeAs(Name = "city")]
        public object City { get; set; }

        [DeserializeAs(Name = "state")]
        public object State { get; set; }

        [DeserializeAs(Name = "zip")]
        public object Zip { get; set; }

        [DeserializeAs(Name = "country")]
        public object Country { get; set; }

        [DeserializeAs(Name = "newsletter")]
        public string Newsletter { get; set; }

        [DeserializeAs(Name = "two_factor")]
        public string TwoFactor { get; set; }

        [DeserializeAs(Name = "subscription_status")]
        public string SubscriptionStatus { get; set; }

        [DeserializeAs(Name = "referral_balance")]
        public string ReferralBalance { get; set; }

        [DeserializeAs(Name = "pref_app_device_id")]
        public bool PrefAppDeviceId { get; set; }
    }
}
