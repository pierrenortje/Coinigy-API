using Coinigy.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class AccountDataRequestTests : TestBase
    {
        [TestMethod]
        public async Task Get_Account_Info()
        {
            var result = await API.AccountDataRequest.GetAccountInfo();
        }

        [TestMethod]
        public async Task Select_Account_Activities()
        {
            var result = await API.AccountDataRequest.SelectAccountActivities();
        }

        [TestMethod]
        public async Task Select_Notifications()
        {
            var result = await API.AccountDataRequest.SelectNotifications();
        }

        [TestMethod]
        public async Task Select_Exchange_Accounts()
        {
            var result = await API.AccountDataRequest.SelectExchangeAccounts();
        }

        [TestMethod]
        public async Task Select_Account_Balances()
        {
            var result = await API.AccountDataRequest.SelectAccountBalances(new AccountModel
            {
                ShowNils = 0,
                AuthIds = ""
            });
        }

        [TestMethod]
        public async Task Select_Account_Balance_History()
        {
            var result = await API.AccountDataRequest.SelectAccountBalanceHistory(new AccountBalanceHistoryModel
            {
                Date = "2016-07-01"
            });
        }

        [TestMethod]
        public async Task Select_Orders()
        {
            var result = await API.AccountDataRequest.SelectOrders();
        }

        [TestMethod]
        public async Task Select_Alerts()
        {
            var result = await API.AccountDataRequest.SelectAlerts();
        }

        [TestMethod]
        public async Task Select_User_Watch_List()
        {
            var result = await API.AccountDataRequest.SelectUserWatchList();
        }

        [TestMethod]
        public async Task Select_News_Feed()
        {
            var result = await API.AccountDataRequest.SelectNewsFeed();
        }
    }
}
