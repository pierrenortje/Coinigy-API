using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class PriceType
    {
        [DeserializeAs(Name = "price_type_id")]
        public string PriceTypeId { get; set; }

        [DeserializeAs(Name = "name")]
        public string Name { get; set; }

        [DeserializeAs(Name = "order")]
        public string Order { get; set; }
    }
}
