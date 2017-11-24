using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class PriceTicker
    {
        [DeserializeAs(Name = "exchange")]
        public string Exchange { get; set; }

        [DeserializeAs(Name = "market")]
        public string Market { get; set; }

        [DeserializeAs(Name = "last_trade")]
        public string LastTrade { get; set; }

        [DeserializeAs(Name = "high_trade")]
        public string HighTrade { get; set; }

        [DeserializeAs(Name = "low_trade")]
        public string LowTrade { get; set; }

        [DeserializeAs(Name = "current_volume")]
        public string CurrentVolume { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public string Timestamp { get; set; }

        [DeserializeAs(Name = "ask")]
        public string Ask { get; set; }

        [DeserializeAs(Name = "bid")]
        public string Bid { get; set; }
    }
}
