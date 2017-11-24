using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Exchange
    {
        [DeserializeAs(Name = "exch_id")]
        public string ExchId { get; set; }

        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "exch_fee")]
        public string ExchFee { get; set; }

        [DeserializeAs(Name = "exch_trade_enabled")]
        public string ExchTradeEnabled { get; set; }

        [DeserializeAs(Name = "exch_balance_enabled")]
        public string ExchBalanceEnabled { get; set; }

        [DeserializeAs(Name = "exch_url")]
        public string ExchUrl { get; set; }
    }
}
