using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Market
    {
        [DeserializeAs(Name = "exch_id")]
        public string exch_id { get; set; }
        public string exch_name { get; set; }
        public string exch_code { get; set; }
        public string mkt_id { get; set; }
        public string mkt_name { get; set; }
        public string exchmkt_id { get; set; }
    }
}
