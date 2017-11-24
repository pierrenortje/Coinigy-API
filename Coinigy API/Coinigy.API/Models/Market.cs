using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Market
    {
        [DeserializeAs(Name = "exch_id")]
        public string ExchId { get; set; }

        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "mkt_id")]
        public string MktId { get; set; }

        [DeserializeAs(Name = "mkt_name")]
        public string MktName { get; set; }

        [DeserializeAs(Name = "exchmkt_id")]
        public string ExchMktId { get; set; }
    }
}
