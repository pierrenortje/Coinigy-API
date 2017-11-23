using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Account
    {
        [DeserializeAs(Name = "auth_id")]
        public string AuthId { get; set; }

        [DeserializeAs(Name = "auth_key")]
        public string AuthKey { get; set; }

        [DeserializeAs(Name = "auth_optional1")]
        public string AuthOptional1 { get; set; }

        [DeserializeAs(Name = "auth_nickname")]
        public string AuthNickname { get; set; }

        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "auth_secret")]
        public string AuthSecret { get; set; }

        [DeserializeAs(Name = "auth_updated")]
        public string AuthUpdated { get; set; }

        [DeserializeAs(Name = "auth_active")]
        public string AuthActive { get; set; }

        [DeserializeAs(Name = "auth_trade")]
        public string AuthTrade { get; set; }

        [DeserializeAs(Name = "exch_trade_enabled")]
        public string ExchTradeRnabled { get; set; }

        [DeserializeAs(Name = "exch_id")]
        public string ExchId { get; set; }
    }
}
