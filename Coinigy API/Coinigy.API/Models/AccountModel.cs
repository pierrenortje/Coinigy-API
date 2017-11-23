using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AccountModel
    {
        [SerializeAs(Name = "show_nils")]
        public int ShowNils { get; set; }

        [SerializeAs(Name = "auth_ids")]
        public string AuthIds { get; set; }
    }
}
