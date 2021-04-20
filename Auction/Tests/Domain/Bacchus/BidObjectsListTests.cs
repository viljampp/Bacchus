using System.Collections.Generic;
using Auction.Bag;
using Auction.Data.Bacchus;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class BidObjectsListTests : ObjectTests<BidObjectsList> {
        protected override BidObjectsList getRandomTestObject() {
            var l = new List<BidDbRecord>();
            SetRandom.Values(l);
            return new BidObjectsList(l);
        }
        [TestMethod] public void CanCreateWithNullArgumentTest() {
            Assert.IsNotNull(new BidObjectsList(null));
        }
    }
}
