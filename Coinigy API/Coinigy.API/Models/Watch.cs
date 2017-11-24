#region License
// Copyright (c) 2017 Pierre Nortje
//
// Permission is hereby granted, free of charge, to any person
// obtaining a copy of this software and associated documentation
// files (the "Software"), to deal in the Software without
// restriction, including without limitation the rights to use,
// copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the
// Software is furnished to do so, subject to the following
// conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
#endregion

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
