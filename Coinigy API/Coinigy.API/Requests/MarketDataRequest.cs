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

using Coinigy.API.Interfaces;
using Coinigy.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coinigy.API.Requests
{
    /// <summary>
    /// Access exchange and market data.
    /// </summary>
    public class MarketDataRequest : RequestBase, IMarketDataRequest
    {
        public MarketDataRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }

        public async Task<BaseResponse<List<Exchange>>> SelectExchanges()
        {
            var request = new RestRequest("exchanges", Method.POST);

            return await base.Execute<BaseResponse<List<Exchange>>>(request);
        }

        public async Task<BaseResponse<List<Market>>> SelectMarkets(MarketModel model)
        {
            var request = new RestRequest("markets", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<List<Market>>>(request);
        }

        public async Task<BaseResponse<MarketData>> SelectMarketData(MarketDataModel model)
        {
            var request = new RestRequest("data", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<MarketData>>(request);
        }

        public async Task<BaseResponse<List<PriceTicker>>> SelectPriceTicker(PriceTickerModel model)
        {
            var request = new RestRequest("ticker", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<List<PriceTicker>>>(request);
        }
    }
}
