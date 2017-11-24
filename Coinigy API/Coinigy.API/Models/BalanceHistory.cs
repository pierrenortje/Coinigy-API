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
    public class BalanceHistory
    {
        [DeserializeAs(Name = "auth_id")]
        public string AuthId { get; set; }

        [DeserializeAs(Name = "balance_curr_code")]
        public string BalanceCurrCode { get; set; }

        [DeserializeAs(Name = "balance_date")]
        public string BalanceDate { get; set; }

        [DeserializeAs(Name = "balance_amount_avail")]
        public string BalanceAmountAvail { get; set; }

        [DeserializeAs(Name = "balance_amount_held")]
        public string BalanceAmountHeld { get; set; }

        [DeserializeAs(Name = "balance_amount_total")]
        public string BalanceAmountTotal { get; set; }

        [DeserializeAs(Name = "btc_value")]
        public string BtcValue { get; set; }

        [DeserializeAs(Name = "timestamp")]
        public string Timestamp { get; set; }
    }
}
