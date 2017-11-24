using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddApiKeyModel
    {
        [SerializeAs(Name = "api_key")]
        public string ApiKey { get; set; }

        [SerializeAs(Name = "api_secret")]
        public string ApiSecret { get; set; }

        [SerializeAs(Name = "api_exch_id")]
        public int ApiExchId { get; set; }

        [SerializeAs(Name = "api_nickname")]
        public string ApiNickname { get; set; }
    }
}
