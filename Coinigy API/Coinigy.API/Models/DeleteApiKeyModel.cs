using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class DeleteApiKeyModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }
    }
}
