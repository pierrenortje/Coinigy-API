using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class BalanceHistory
    {
        [DeserializeAs(Name = "auth_id")]
        public string AuthId { get; set; }

        [DeserializeAs(Name = "balance_curr_code")]
        public string BalanceCurrCode { get; set; }

        [DeserializeAs(Name = "balance_date")]
        public string BalanceDate { get; set; }

        [DeserializeAs(Name = "balance_amount_avail")]
        public string BalanceAmountAvail { get; set; }

        [DeserializeAs(Name = "balance_amount_held")]
        public string BalanceAmountHeld { get; set; }

        [DeserializeAs(Name = "balance_amount_total")]
        public string BalanceAmountTotal { get; set; }

        [DeserializeAs(Name = "btc_value")]
        public string BtcValue { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public string Timestamp { get; set; }
    }
}
