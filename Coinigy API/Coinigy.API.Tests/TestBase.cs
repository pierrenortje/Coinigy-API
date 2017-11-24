using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;

        private const string apiKey = "[YOUR-API-KEY]";
        private const string apiSecret = "[YOUR-API-SECRET]";
        #endregion

        #region Public Properties
        public ApiRequest API
        {
            get
            {
                return this.api;
            }
        }
        #endregion

        #region Public Methods
        [TestInitialize]
        public void Init()
        {
            this.api = new ApiRequest(apiKey, apiSecret);
        }
        #endregion
    }
}
