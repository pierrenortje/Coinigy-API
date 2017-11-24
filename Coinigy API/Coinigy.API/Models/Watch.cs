using RestSharp.Deserializers;

namespace Coinigy.API.Models
{
    public class Watch
    {
        [DeserializeAs(Name = "exchmkt_id")]
        public string ExchMktId { get; set; }

        [DeserializeAs(Name = "mkt_name")]
        public string MktName { get; set; }

        [DeserializeAs(Name = "exch_code")]
        public string ExchCode { get; set; }

        [DeserializeAs(Name = "exch_name")]
        public string ExchName { get; set; }

        [DeserializeAs(Name = "primary_currency_name")]
        public string PrimaryCurrencyName { get; set; }

        [DeserializeAs(Name = "secondary_currency_name")]
        public string SecondaryCurrencyName { get; set; }

        [DeserializeAs(Name = "server_time")]
        public string ServerTime { get; set; }

        [DeserializeAs(Name = "last_price")]
        public string LastPrice { get; set; }

        [DeserializeAs(Name = "prev_price")]
        public string PrevPrice { get; set; }

        [DeserializeAs(Name = "high_trade")]
        public string HighTrade { get; set; }

        [DeserializeAs(Name = "low_trade")]
        public string LowTrade { get; set; }

        [DeserializeAs(Name = "current_volume")]
        public string CurrentVolume { get; set; }

        [DeserializeAs(Name = "fiat_market")]
        public string FiatMarket { get; set; }

        [DeserializeAs(Name = "btc_volume")]
        public string BtcVolume { get; set; }
    }
}
