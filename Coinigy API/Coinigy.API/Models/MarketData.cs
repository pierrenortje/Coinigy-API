using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class MarketData
    {
        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "primary_curr_code")]
        public string PrimaryCurrCode { get; set; }

        [DeserializeAs(Name = "secondary_curr_code")]
        public string SecondaryCurrCode { get; set; }

        [DeserializeAs(Name = "type")]
        public string Type { get; set; }

        [DeserializeAs(Name = "history")]
        public List<MarketHistory> History { get; set; }

        [DeserializeAs(Name = "asks")]
        public List<MarketAsk> Asks { get; set; }

        [DeserializeAs(Name = "bids")]
        public List<MarketBid> Bids { get; set; }
    }
}
