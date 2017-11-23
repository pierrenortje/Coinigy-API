using Coinigy.API.Requests;
using RestSharp;
using System;

namespace Coinigy.API
{
    public class ApiRequest
    {
        #region Private Fields
        private readonly IRestClient restClient;
        private readonly string apiKey;
        private readonly string apiSecret;
        #endregion

        #region Constructor
        public ApiRequest(string apiKey, string apiSecret)
        {
            this.restClient = new RestClient
            {
#if DEBUG
                BaseUrl = new Uri("https://private-anon-f5c84d1c79-coinigy.apiary-proxy.com/api/v1/")
#else
                BaseUrl = new Uri("https://api.coinigy.com/api/v1/")
#endif
            };

            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }
#endregion

#region Public Properties
        public AccountDataRequest AccountDataRequest { get { return new AccountDataRequest(this.restClient, this.apiKey, this.apiSecret); } }
        public AccountFunctionsRequest AccountFunctionsRequest { get { return new AccountFunctionsRequest(this.restClient, this.apiKey, this.apiSecret); } }
        public MarketDataRequest MarketDataRequest { get { return new MarketDataRequest(this.restClient, this.apiKey, this.apiSecret); } }
#endregion
    }
}
