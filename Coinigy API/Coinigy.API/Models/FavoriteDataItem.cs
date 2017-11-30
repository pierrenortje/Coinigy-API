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

using Newtonsoft.Json;

namespace Coinigy.API.Models
{
    public class FavoriteDataItem
    {
        [JsonProperty("exch_code")]
        public string ExchCode { get; set; }

        [JsonProperty("last_price")]
        public double LastPrice { get; set; }

        [JsonProperty("btc_volume_24")]
        public double BtcVolume24 { get; set; }

        [JsonProperty("base_curr")]
        public string BaseCurr { get; set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; set; }

        [JsonProperty("exch_name")]
        public string ExchName { get; set; }

        [JsonProperty("exch_id")]
        public long ExchId { get; set; }

        [JsonProperty("exchmkt_id")]
        public long ExchmktId { get; set; }

        [JsonProperty("mkt_name")]
        public string MktName { get; set; }

        [JsonProperty("mkt_id")]
        public long MktId { get; set; }

        [JsonProperty("primary_curr")]
        public string PrimaryCurr { get; set; }

        [JsonProperty("volume_24")]
        public double Volume24 { get; set; }
    }
}
