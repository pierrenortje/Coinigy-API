using Coinigy.API.Interfaces;
using RestSharp;

namespace Coinigy.API.Requests
{
    public class AccountFunctionsRequest : RequestBase, IAccountFunctionsRequest
    {
        public AccountFunctionsRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }
    }
}
