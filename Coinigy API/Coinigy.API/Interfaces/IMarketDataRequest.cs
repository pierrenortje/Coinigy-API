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
