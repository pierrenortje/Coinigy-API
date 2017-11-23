using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class ActivateApiKeyModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }

        [SerializeAs(Name = "auth_active")]
        public int AuthActive { get; set; }
    }
}
