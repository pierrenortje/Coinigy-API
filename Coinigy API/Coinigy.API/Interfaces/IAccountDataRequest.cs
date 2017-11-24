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
    public interface IAccountDataRequest
    {
        /// <summary>
        /// Returns your account information and preferences.
        /// Note: For security purposes, the "userInfo" method is only available by request. Please contact support to request access.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<AccountInfo>>> GetAccountInfo();

        /// <summary>
        /// Returns a list of your recent account activity.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<AccountActivity>>> SelectAccountActivities();

        /// <summary>
        /// List any unshown alerts or trade notifications.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<Notification>>> SelectNotifications();

        /// <summary>
        /// Returns a list of your attached exchange accounts and wallets, each with a unique auth_id.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<Account>>> SelectExchangeAccounts();

        /// <summary>
        /// Returns a combined list of balances for all accounts, or specificied auth_ids.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<AccountBalance>>> SelectAccountBalances(AccountModel model);

        /// <summary>
        /// Returns balances for your entire account on given date.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<AccountBalanceHistory>> SelectAccountBalanceHistory(AccountBalanceHistoryModel model);

        /// <summary>
        /// Returns a list of all open orders and recent order history.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<Order>>> SelectOrders();

        /// <summary>
        /// Returns a list of all open alerts and recent alert history.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<Alert>> SelectAlerts();

        /// <summary>
        /// Returns ticker data on your favorite markets (as selected on Coinigy.com).
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<Watch>>> SelectUserWatchList();

        /// <summary>
        /// Returns a list of the latest items from Coinigy's newsfeed sources.
        /// </summary>
        /// <returns></returns>
        Task<BaseResponse<List<NewsFeed>>> SelectNewsFeed();
    }
}
