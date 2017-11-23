using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coinigy.API.Tests
{
    [TestClass]
    public class TestBase
    {
        #region Private Fields
        private ApiRequest api;

        private const string apiKey = "30fa4e901c8df133e9ba3867d9409c6d";
        private const string apiSecret = "fd283fa0fc3ad29f53fad04083fd654b";
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
