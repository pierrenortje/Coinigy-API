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

using Coinigy.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coinigy.API.Interfaces
{
    public interface IMarketDataRequest
    {
        /// <summary>
        /// Returns a list of all supported exchanges.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<Exchange>>> SelectExchanges();

        /// <summary>
        /// Returns a list of markets on specified exchange.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<BaseResponse<List<Market>>> SelectMarkets(MarketModel model);

        /// <summary>
        /// Trade history, asks and bids for any supported exchange/market.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<BaseResponse<MarketData>> SelectMarketData(MarketDataModel model);

        /// <summary>
        /// Returns last, high (24h), low (24h), ask, bid for specified market.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Task<BaseResponse<List<PriceTicker>>> SelectPriceTicker(PriceTickerModel model);
    }
}
