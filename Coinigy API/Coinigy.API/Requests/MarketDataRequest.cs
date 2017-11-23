using Coinigy.API.Interfaces;
using RestSharp;

namespace Coinigy.API.Requests
{
    public class MarketDataRequest : RequestBase, IMarketDataRequest
    {
        public MarketDataRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }

    }
}
