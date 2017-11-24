using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class AccountBalanceHistory
    {
        [DeserializeAs(Name = "balance_history")]
        public List<BalanceHistory> BalanceHistory { get; set; }
    }
}
