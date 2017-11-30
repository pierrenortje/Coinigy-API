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
    public class BlockItem
    {
        [JsonProperty("block_time")]
        public string BlockTime { get; set; }

        [JsonProperty("diff")]
        public double Diff { get; set; }

        [JsonProperty("block_reward")]
        public long BlockReward { get; set; }

        [JsonProperty("block_id")]
        public long BlockId { get; set; }

        [JsonProperty("block_size")]
        public long BlockSize { get; set; }

        [JsonProperty("btc_market_cap")]
        public double BtcMarketCap { get; set; }

        [JsonProperty("btc_exch_rate")]
        public double BtcExchRate { get; set; }

        [JsonProperty("curr_code")]
        public string CurrCode { get; set; }

        [JsonProperty("outstanding")]
        public double Outstanding { get; set; }

        [JsonProperty("usd_exch_rate")]
        public double UsdExchRate { get; set; }

        [JsonProperty("miner")]
        public string Miner { get; set; }

        [JsonProperty("txc")]
        public long Txc { get; set; }

        [JsonProperty("usd_market_cap")]
        public double UsdMarketCap { get; set; }

        internal static string ParseBlockInfo(string data) => data.Split('-')[1];
    }
}
