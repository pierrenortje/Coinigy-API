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
