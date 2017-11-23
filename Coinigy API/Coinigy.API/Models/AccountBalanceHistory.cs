using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class BalanceHistory
    {
        public string auth_id { get; set; }
        public string balance_curr_code { get; set; }
        public string balance_date { get; set; }
        public string balance_amount_avail { get; set; }
        public string balance_amount_held { get; set; }
        public string balance_amount_total { get; set; }
        public string btc_value { get; set; }
        public string timestamp { get; set; }
    }

    public class AccountBalanceHistory
    {
        public List<BalanceHistory> balance_history { get; set; }
    }
}
