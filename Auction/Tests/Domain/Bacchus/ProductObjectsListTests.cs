using System.Collections.Generic;
using Auction.Bag;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class ProductObjectsListTests : ObjectTests<ProductObjectsList> {
        protected override ProductObjectsList getRandomTestObject() {
            var l = new List<ProductObject>();
            SetRandom.Values(l);
            return new ProductObjectsList(l);
        }
        [TestMethod] public void CanCreateWithNullArgumentTest() {
            Assert.IsNotNull(new ProductObjectsList(null));
        }
    }
}
