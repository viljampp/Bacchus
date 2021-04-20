using Auction.Bag;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Bacchus {
    [TestClass] public class BidViewModelsListTests : ObjectTests<BidViewModelsList> {
        protected override BidViewModelsList getRandomTestObject() {
            var l = new BidObjectsList(null);
            SetRandom.Values(l);
            return new BidViewModelsList(l);
        }

        [TestMethod] public void CanCreateWithNullArgumentTest() {
            Assert.IsNotNull(new BidViewModelsList(null));
        }

    }
}
