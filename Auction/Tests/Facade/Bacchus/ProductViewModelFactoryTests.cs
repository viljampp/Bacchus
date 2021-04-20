using System;
using System.Globalization;
using Auction.Bag;
using Auction.Core;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Facade.Bacchus {
    [TestClass] public class ProductViewModelFactoryTests : BaseTests {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(ProductViewModelFactory);
        }

        [TestMethod] public void CreateTest() {
            var o = GetRandom.Object<ProductObject>();
            var v = ProductViewModelFactory.Create(o);
            
            Assert.AreEqual(v.Id, o.Id);
            Assert.AreEqual(v.Name, o.Name);
            Assert.AreEqual(v.Description, o.Description);
            Assert.AreEqual(v.Category, o.Category);
            Assert.AreEqual(v.BiddingEndDate, ProductViewModelFactory.timeLeft(o.BiddingEndDate));
        }
    }
}
