using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddOrderModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }

        [SerializeAs(Name = "exch_id")]
        public int ExchId { get; set; }

        [SerializeAs(Name = "mkt_id")]
        public int MktId { get; set; }

        [SerializeAs(Name = "order_type_id")]
        public int OrderTypeId { get; set; }

        [SerializeAs(Name = "price_type_id")]
        public int PriceTypeId { get; set; }

        [SerializeAs(Name = "limit_price")]
        public int LimitPrice { get; set; }

        [SerializeAs(Name = "order_quantity")]
        public double OrderQuantity { get; set; }
    }
}
