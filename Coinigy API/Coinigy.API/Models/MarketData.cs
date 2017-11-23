using RestSharp.Deserializers;
using System.Collections.Generic;

namespace Coinigy.API.Models
{
    public class MarketData
    {
        [DeserializeAs(Name = "exch_code")]
        public string exch_code { get; set; }
        public string primary_curr_code { get; set; }
        public string secondary_curr_code { get; set; }
        public string type { get; set; }
        public List<History> history { get; set; }
        public List<Ask> asks { get; set; }
        public List<Bid> bids { get; set; }
    }

    public class History
    {
        public string price { get; set; }
        public string quantity { get; set; }
        public string time_local { get; set; }
        public string type { get; set; }
    }

    public class Ask
    {
        public string price { get; set; }
        public string quantity { get; set; }
        public string total { get; set; }
    }

    public class Bid
    {
        public string price { get; set; }
        public string quantity { get; set; }
        public string total { get; set; }
    }
}
