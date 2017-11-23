using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddApiKeyModel
    {
        [SerializeAs(Name = "api_key")]
        public string api_key { get; set; }
        public string api_secret { get; set; }
        public int api_exch_id { get; set; }
        public string api_nickname { get; set; }
    }
}
