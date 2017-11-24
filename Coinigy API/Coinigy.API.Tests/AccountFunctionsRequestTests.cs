using Coinigy.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class AccountFunctionsRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Exchanges()
        {
            var result = await API.AccountFunctionsRequest.UpdateUser(new UpdateUserModel
            {
                FirstName = "John",
                LastName = "Doe"
            });
        }

        [TestMethod]
        public async Task Update_Notification_Preferences()
        {
            var result = await API.AccountFunctionsRequest.UpdateNotificationPreferences(new UpdateNotificationPreferencesModel
            {
                AlertEmail = 1,
                AlertSms = 0,
                TradeEmail = 1,
                TradeSms = 1,
                BalanceEmail = 1
            });
        }

        [TestMethod]
        public async Task Update_Tickers()
        {
            var result = await API.AccountFunctionsRequest.UpdateTickers(new UpdateTickersModel
            {
                ExchMktIds = "7435,3401,3373,3385,6748,132,1146,363"
            });
        }

        [TestMethod]
        public async Task Select_Order_Types()
        {
            var result = await API.AccountFunctionsRequest.SelectOrderTypes();
        }

        [TestMethod]
        public async Task Refresh_Balance()
        {
            var result = await API.AccountFunctionsRequest.RefreshBalance(new RefreshBalanceModel
            {
                AuthId = 1234
            });
        }

        [TestMethod]
        public async Task Add_Alert()
        {
            var result = await API.AccountFunctionsRequest.AddAlert(new AddAlertModel
            {
                ExchCode = "GDAX",
                MarketName = "BTC/USD",
                AlertPrice = 750.01,
                AlertNote = "This is an optional message"
            });
        }

        [TestMethod]
        public async Task Delete_Alert()
        {
            var result = await API.AccountFunctionsRequest.DeleteAlert(new DeleteAlertModel
            {
                AlertId = 69468
            });
        }

        [TestMethod]
        public async Task Add_Api_Key()
        {
            var result = await API.AccountFunctionsRequest.AddApiKey(new AddApiKeyModel
            {
                ApiKey = "363f41b7e25674d0eb487153f2c04468",
                ApiSecret = "7adcdb76404ead6cbb8229e8535db473",
                ApiExchId = 7,
                ApiNickname = "My New Exchange Account"
            });
        }

        [TestMethod]
        public async Task Delete_Api_Key()
        {
            var result = await API.AccountFunctionsRequest.DeleteApiKey(new DeleteApiKeyModel
            {
                AuthId = 7284
            });
        }

        [TestMethod]
        public async Task Activate_Api_Key()
        {
            var result = await API.AccountFunctionsRequest.ActivateApiKey(new ActivateApiKeyModel
            {
                AuthId = 7284,
                AuthActive = 1
            });
        }

        [TestMethod]
        public async Task Activate_Trading_Key()
        {
            var result = await API.AccountFunctionsRequest.ActivateTradingKey(new ActivateTradingKeyModel
            {
                AuthId = 7284,
                AuthTrade = 1
            });
        }

        [TestMethod]
        public async Task Add_Order()
        {
            var result = await API.AccountFunctionsRequest.AddOrder(new AddOrderModel
            {
                AuthId = 1234,
                ExchId = 62,
                MktId = 125,
                OrderTypeId = 2,
                PriceTypeId = 3,
                LimitPrice = 755,
                OrderQuantity = 0.01
            });
        }

        [TestMethod]
        public async Task Cancel_Order()
        {
            var result = await API.AccountFunctionsRequest.CancelOrder(new CancelOrderModel
            {
                InternalOrderId = 1234567
            });
        }
    }
}
