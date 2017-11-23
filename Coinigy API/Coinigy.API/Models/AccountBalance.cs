using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class AccountBalance
    {
        [DeserializeAs(Name = "balance_curr_code")]
        public string BalanceCurrCode { get; set; }

        [DeserializeAs(Name = "balance_amount_avail")]
        public string BalanceAmountAvail { get; set; }

        [DeserializeAs(Name = "balance_amount_held")]
        public string BalanceAmountHeld { get; set; }

        [DeserializeAs(Name = "balance_amount_total")]
        public string BalanceAmountTotal { get; set; }

        [DeserializeAs(Name = "btc_balance")]
        public string BtcBalance { get; set; }

        [DeserializeAs(Name = "last_price")]
        public string LastPrice { get; set; }
    }
}
