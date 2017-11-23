using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class PriceTicker
    {
        [DeserializeAs(Name = "exchange")]
        public string exchange { get; set; }
        public string market { get; set; }
        public string last_trade { get; set; }
        public string high_trade { get; set; }
        public string low_trade { get; set; }
        public string current_volume { get; set; }
        public string timestamp { get; set; }
        public string ask { get; set; }
        public string bid { get; set; }
    }
}
