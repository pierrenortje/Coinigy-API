using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class CancelOrderModel
    {
        [SerializeAs(Name = "internal_order_id")]
        public int InternalOrderId { get; set; }
    }
}
