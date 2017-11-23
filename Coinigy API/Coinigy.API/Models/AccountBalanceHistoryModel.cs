using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AccountBalanceHistoryModel
    {
        /// <summary>
        /// The date in yyyy-MM-dd format.
        /// </summary>
        [SerializeAs(Name = "date")]
        public string Date { get; set; }
    }
}
