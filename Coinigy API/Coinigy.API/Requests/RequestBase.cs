using RestSharp;
using System.Net;
using System.Threading.Tasks;

namespace Coinigy.API.Requests
{
    public class RequestBase
    {
        #region Protected Fields
        protected readonly IRestClient restClient;
        protected readonly string apiKey;
        protected readonly string apiSecret;
        #endregion

        #region Constructor
        public RequestBase(IRestClient restClient, string apiKey, string apiSecret)
        {
            this.restClient = restClient;
            this.apiKey = apiKey;
            this.apiSecret = apiSecret;
        }
        #endregion

        #region Public Properties
        public HttpStatusCode StatusCode { get; set; }
        public string StatusDescription { get; set; }
        #endregion

        #region Protected Methods
        protected async Task<TResponseType> Execute<TResponseType>(IRestRequest request)
        {
            request.AddHeader("X-API-KEY", this.apiKey);
            request.AddHeader("X-API-SECRET", this.apiSecret);

            var response = await restClient.ExecuteTaskAsync<TResponseType>(request);

            StatusDescription = response.StatusDescription;
            StatusCode = response.StatusCode;

            return response.Data;
        }
        #endregion
    }
}
