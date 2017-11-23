using Coinigy.API.Interfaces;
using Coinigy.API.Models;
using RestSharp;
using System.Threading.Tasks;

namespace Coinigy.API.Requests
{
    public class AccountDataRequest : RequestBase, IAccountDataRequest
    {
        public AccountDataRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }

        public async Task<BaseResponse<AccountInfo>> GetAccountInfo()
        {
            var request = new RestRequest("userInfo", Method.POST);

            return await base.Execute<BaseResponse<AccountInfo>>(request);
        }
    }
}
