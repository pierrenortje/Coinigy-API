using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class DeleteAlertModel
    {
        [SerializeAs(Name = "alert_id")]
        public int AlertId { get; set; }
    }
}
