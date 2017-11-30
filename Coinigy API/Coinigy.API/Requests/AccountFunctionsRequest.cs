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
    /// Private account methods - place alerts, orders, refresh balances.
    /// </summary>
    public class AccountFunctionsRequest : RequestBase, IAccountFunctionsRequest
    {
        public AccountFunctionsRequest(IRestClient restClient, string apiKey, string apiSecret) : base(restClient, apiKey, apiSecret) { }

        public async Task<BaseResponse<object>> UpdateUser(UpdateUserModel model)
        {
            var request = new RestRequest("updateUser", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<object>> UpdateNotificationPreferences(UpdateNotificationPreferencesModel model)
        {
            var request = new RestRequest("savePrefs", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<object>> UpdateTickers(UpdateTickersModel model)
        {
            var request = new RestRequest("updateTickers", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<OrderType>> SelectOrderTypes()
        {
            var request = new RestRequest("orderTypes", Method.POST);

            return await base.Execute<BaseResponse<OrderType>>(request);
        }

        public async Task<BaseResponse<List<AccountBalance>>> RefreshBalance(RefreshBalanceModel model)
        {
            var request = new RestRequest("refreshBalance", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<List<AccountBalance>>>(request);
        }

        public async Task<BaseResponse<object>> AddAlert(AddAlertModel model)
        {
            var request = new RestRequest("addAlert", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<object>> DeleteAlert(DeleteAlertModel model)
        {
            var request = new RestRequest("deleteAlert", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<int>> AddApiKey(AddApiKeyModel model)
        {
            var request = new RestRequest("addApiKey", Method.POST);

            request.AddParameter("api_key", model.ApiKey);
            request.AddParameter("api_secret", model.ApiSecret);
            request.AddParameter("api_exch_id", model.ApiExchId);
            request.AddParameter("api_nickname", model.ApiNickname);

            return await base.Execute<BaseResponse<int>>(request);
        }

        public async Task<BaseResponse<object>> DeleteApiKey(DeleteApiKeyModel model)
        {
            var request = new RestRequest("deleteApiKey", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<object>> ActivateApiKey(ActivateApiKeyModel model)
        {
            var request = new RestRequest("activateApiKey", Method.POST);

            request.AddParameter("auth_id", model.AuthId);
            request.AddParameter("auth_active", model.AuthActive);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<object>> ActivateTradingKey(ActivateTradingKeyModel model)
        {
            var request = new RestRequest("activateTradingKey", Method.POST);

            request.AddParameter("auth_id", model.AuthId);
            request.AddParameter("auth_trade", model.AuthTrade);

            return await base.Execute<BaseResponse<object>>(request);
        }

        public async Task<BaseResponse<InternalOrder>> AddOrder(AddOrderModel model)
        {
            var request = new RestRequest("addOrder", Method.POST);

            request.AddParameter("auth_id", model.AuthId);
            request.AddParameter("exch_id", model.ExchId);
            request.AddParameter("mkt_id", model.MktId);
            request.AddParameter("order_type_id", model.OrderTypeId);
            request.AddParameter("price_type_id", model.PriceTypeId);
            request.AddParameter("limit_price", model.LimitPrice);
            request.AddParameter("order_quantity", model.OrderQuantity);

            return await base.Execute<BaseResponse<InternalOrder>>(request);
        }

        public async Task<BaseResponse<object>> CancelOrder(CancelOrderModel model)
        {
            var request = new RestRequest("cancelOrder", Method.POST);
            request.AddJsonBody(model);

            return await base.Execute<BaseResponse<object>>(request);
        }
    }
}
