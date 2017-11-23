using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class ActivateTradingKeyModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }

        [SerializeAs(Name = "auth_trade")]
        public int AuthTrade { get; set; }
    }
}
