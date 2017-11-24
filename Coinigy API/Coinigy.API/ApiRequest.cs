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
