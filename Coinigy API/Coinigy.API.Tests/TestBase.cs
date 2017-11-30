using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;
        #endregion

        #region Public Fields
        public const string ApiKey = "[YOUR-API-KEY]";
        public const string ApiSecret = "[YOUR-API-SECRET]";
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
            this.api = new ApiRequest(ApiKey, ApiSecret);
        }
        #endregion
    }
}
