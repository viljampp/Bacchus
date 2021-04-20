using Auction.Bag;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Facade.Bacchus {
    [TestClass] public class ProductViewModelsListTests : ObjectTests<ProductViewModelsList> {
        protected override ProductViewModelsList getRandomTestObject() {
            var l = new ProductObjectsList(null);
            SetRandom.Values(l);
            return new ProductViewModelsList(l);
        }

        [TestMethod] public void CanCreateWithNullArgumentTest() {
            Assert.IsNotNull(new ProductViewModelsList(null));
        }
    }
}
