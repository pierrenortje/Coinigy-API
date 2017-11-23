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
