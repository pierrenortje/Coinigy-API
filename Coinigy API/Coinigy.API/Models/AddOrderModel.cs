using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddOrderModel
    {
        [SerializeAs(Name = "auth_id")]
        public int auth_id { get; set; }
        public int exch_id { get; set; }
        public int mkt_id { get; set; }
        public int order_type_id { get; set; }
        public int price_type_id { get; set; }
        public int limit_price { get; set; }
        public double order_quantity { get; set; }
    }
}
