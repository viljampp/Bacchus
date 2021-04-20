using Auction.Bag;
using Auction.Facade.Bacchus;
using Auction.Facade.Common;
using Auction.Tests.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Bacchus {
    [TestClass] public class BidViewModelTests : ViewModelTests<BidViewModel, NamedViewModel> {
        protected override BidViewModel getRandomTestObject() {
            return GetRandom.Object<BidViewModel>();
        }

        [TestMethod] public void ProductIdTest() {
            testReadWriteProperty(() => obj.ProductId, x => obj.ProductId = x);
        }
        [TestMethod] public void UserIdTest() {
            testReadWriteProperty(() => obj.UserId, x => obj.UserId = x);
        }
        [TestMethod] public void PriceTest() {
            testReadWriteProperty(() => obj.Price, x => obj.Price = x);
        }
    }
}
