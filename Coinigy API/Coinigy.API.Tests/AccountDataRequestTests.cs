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
    }
}
