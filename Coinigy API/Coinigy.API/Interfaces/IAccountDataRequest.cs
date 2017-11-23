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
