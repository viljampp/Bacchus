using Auction.Bag;
using Auction.Facade.Bacchus;
using Auction.Facade.Components;
using Auction.Tests.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Facade.Components {
    [TestClass]
    public class
        CategoryMenuViewModelTests : ViewModelTests<CategoryMenuViewModel, ProductViewModel> {
        protected override CategoryMenuViewModel getRandomTestObject() {
            return GetRandom.Object<CategoryMenuViewModel>();
        }

        [TestMethod] public void ProductsTest() {
            Assert.AreNotEqual(obj.Products, null);
        }
    }
}
