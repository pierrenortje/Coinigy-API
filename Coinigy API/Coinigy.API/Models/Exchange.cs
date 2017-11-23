using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Exchange
    {
        [DeserializeAs(Name = "exch_id")]
        public string exch_id { get; set; }
        public string exch_name { get; set; }
        public string exch_code { get; set; }
        public string exch_fee { get; set; }
        public string exch_trade_enabled { get; set; }
        public string exch_balance_enabled { get; set; }
        public string exch_url { get; set; }
    }
}
