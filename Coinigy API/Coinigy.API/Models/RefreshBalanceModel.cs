using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class RefreshBalanceModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }
    }
}
