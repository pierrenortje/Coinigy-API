using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class InternalOrder
    {
        [DeserializeAs(Name = "internal_order_id")]
        public string InternalOrderId { get; set; }
    }
}
