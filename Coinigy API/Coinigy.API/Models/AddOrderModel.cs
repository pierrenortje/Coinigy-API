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

using RestSharp.Serializers;

namespace Coinigy.API.Models
{
    public class AddOrderModel
    {
        [SerializeAs(Name = "auth_id")]
        public int AuthId { get; set; }

        [SerializeAs(Name = "exch_id")]
        public int ExchId { get; set; }

        [SerializeAs(Name = "mkt_id")]
        public int MktId { get; set; }

        [SerializeAs(Name = "order_type_id")]
        public int OrderTypeId { get; set; }

        [SerializeAs(Name = "price_type_id")]
        public int PriceTypeId { get; set; }

        [SerializeAs(Name = "limit_price")]
        public int LimitPrice { get; set; }

        [SerializeAs(Name = "order_quantity")]
        public double OrderQuantity { get; set; }
    }
}
