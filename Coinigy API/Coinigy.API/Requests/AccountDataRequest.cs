using Coinigy.API.Interfaces;
using Coinigy.API.Models;
using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coinigy.API.Requests
{
    /// <summary>
    /// Gather information about your Coinigy account.
    /// </summary>
    public class AccountDataRequest : RequestBase, IAccountDataRequest
    {
        public AccountDataRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }

        public async Task<BaseResponse<List<AccountInfo>>> GetAccountInfo()
        {
            var request = new RestRequest("userInfo", Method.POST);

            return await base.Execute<BaseResponse<List<AccountInfo>>>(request);
        }

        public async Task<BaseResponse<List<AccountActivity>>> SelectAccountActivities()
        {
            var request = new RestRequest("activity", Method.POST);

            return await base.Execute<BaseResponse<List<AccountActivity>>>(request);
        }

        public async Task<BaseResponse<List<Notification>>> SelectNotifications()
        {
            var request = new RestRequest("pushNotifications", Method.POST);

            return await base.Execute<BaseResponse<List<Notification>>>(request);
        }

        public async Task<BaseResponse<List<Account>>> SelectExchangeAccounts()
        {
            var request = new RestRequest("accounts", Method.POST);

            return await base.Execute<BaseResponse<List<Account>>>(request);
        }

        public async Task<BaseResponse<List<AccountBalance>>> SelectAccountBalances(AccountModel model)
        {
            var request = new RestRequest("balances", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<List<AccountBalance>>>(request);
        }

        public async Task<BaseResponse<AccountBalanceHistory>> SelectAccountBalanceHistory(AccountBalanceHistoryModel model)
        {
            var request = new RestRequest("balanceHistory", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<AccountBalanceHistory>>(request);
        }

        public async Task<BaseResponse<List<Order>>> SelectOrders()
        {
            var request = new RestRequest("orders", Method.POST);

            return await base.Execute<BaseResponse<List<Order>>>(request);
        }

        public async Task<BaseResponse<Alert>> SelectAlerts()
        {
            var request = new RestRequest("alerts", Method.POST);

            return await base.Execute<BaseResponse<Alert>>(request);
        }

        public async Task<BaseResponse<List<Watch>>> SelectUserWatchList()
        {
            var request = new RestRequest("userWatchList", Method.POST);

            return await base.Execute<BaseResponse<List<Watch>>>(request);
        }

        public async Task<BaseResponse<List<NewsFeed>>> SelectNewsFeed()
        {
            var request = new RestRequest("newsFeed", Method.POST);

            return await base.Execute<BaseResponse<List<NewsFeed>>>(request);
        }
    }
}
