using Auction.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Core {
    [TestClass] public class ConstantsTests : BaseTests {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(Constants);
        }
        [TestMethod] public void UnspecifiedTest() {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(Constants.Unspecified.Trim()));
        }
        [TestMethod] public void NotFoundTest() {
            Assert.IsTrue(!string.IsNullOrWhiteSpace(Constants.NotFound.Trim()));
        }
        [TestMethod] public void DefaultPrizeTest() {
            Assert.AreEqual(Constants.DefaultPrize, 0);
        }
    }
}



