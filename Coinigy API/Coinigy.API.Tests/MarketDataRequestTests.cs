using Coinigy.API.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class MarketDataRequestTests : TestBase
    {
        [TestMethod]
        public async Task Select_Exchanges()
        {
            var result = await API.MarketDataRequest.SelectExchanges();
        }

        [TestMethod]
        public async Task Select_Markets()
        {
            var result = await API.MarketDataRequest.SelectMarkets(new MarketModel
            {
                ExchangeCode = "GDAX"
            });
        }

        [TestMethod]
        public async Task Select_Market_Data()
        {
            var result = await API.MarketDataRequest.SelectMarketData(new MarketDataModel
            {
                ExchangeCode = "GDAX",
                ExchangeMarket = "BTC/USD",
                Type = MarketDataType.History
            });
        }

        [TestMethod]
        public async Task Select_Price_Ticker()
        {
            var result = await API.MarketDataRequest.SelectPriceTicker(new PriceTickerModel
            {
                ExchangeCode = "GDAX",
                ExchangeMarket = "BTC/USD"
            });
        }
    }
}
