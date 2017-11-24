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

using Coinigy.API.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Coinigy.API.Interfaces
{
    public interface IAccountFunctionsRequest
    {
        /// <summary>
        /// Update your account information on record.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> UpdateUser(UpdateUserModel model);

        /// <summary>
        /// Update your notification preferences (alerts, trades, balances) via (email, sms).
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> UpdateNotificationPreferences(UpdateNotificationPreferencesModel model);

        /// <summary>
        /// Update your favorite markets/tickers based on exch_mkt_id.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> UpdateTickers(UpdateTickersModel model);

        /// <summary>
        /// Returns a list of supported order and price types.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<OrderType>> SelectOrderTypes();

        /// <summary>
        /// Refresh balances on specified auth_id.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<AccountBalance>>> RefreshBalance(RefreshBalanceModel model);

        /// <summary>
        /// Add a new price alert.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> AddAlert(AddAlertModel model);

        /// <summary>
        /// Delete existing price alert.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> DeleteAlert(DeleteAlertModel model);

        /// <summary>
        /// Add a new Exchange API Key to your account.
        /// Returns newly-generated auth_id in "data" block. After adding a new key,
        /// it must still be both activated (/activateApiKey) and activated for trading
        /// (/activateTradingKey).
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<int>> AddApiKey(AddApiKeyModel model);

        /// <summary>
        /// Delete specified Exchange API Account.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> DeleteApiKey(DeleteApiKeyModel model);

        /// <summary>
        /// Activate/Enable API Key usage (enables automatic balance monitoring).
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> ActivateApiKey(ActivateApiKeyModel model);

        /// <summary>
        /// Activate/Enable Trading on specified API key.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> ActivateTradingKey(ActivateTradingKeyModel model);

        /// <summary>
        /// Create a new exchange order. Returns internal_order_id upon success.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<InternalOrder>>> AddOrder(AddOrderModel model);

        /// <summary>
        /// Cancel an outstanding exchange order.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<object>> CancelOrder(CancelOrderModel model);
    }
}
