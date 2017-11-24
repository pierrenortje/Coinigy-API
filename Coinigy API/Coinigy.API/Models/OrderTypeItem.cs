using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class OrderTypeItem
    {
        [DeserializeAs(Name = "order_type_id")]
        public string OrderTypeId { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "order")]
        public string Order { get; set; }
    }
}
