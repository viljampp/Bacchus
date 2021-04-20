using System;
using Auction.Bag;
using Auction.Core;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class ProductObjectFactoryTests : BaseTests {
        private string id;
        private string name;
        private string description;
        private string category;
        private DateTime biddingEndDate;
        private ProductObject o;
        private void initializeTestData() {
            var min = DateTime.Now.AddYears(-50);
            var max = DateTime.Now.AddYears(50);
            id = GetRandom.String();
            name = GetRandom.String();
            description = GetRandom.String();
            category = GetRandom.String();
            biddingEndDate = GetRandom.DateTime(min, max);
        }
        private void validateResults(string i = Constants.Unspecified,
            string n = Constants.Unspecified, string d = Constants.Unspecified,
            string c = Constants.Unspecified, DateTime? b = null) {
            var productObject = o;
            Assert.AreEqual(i, productObject.Id);
            Assert.AreEqual(n, productObject.Name);
            Assert.AreEqual(d, productObject.Description);
            Assert.AreEqual(c, productObject.Category);
            Assert.AreEqual(b, productObject.BiddingEndDate);
        }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(ProductObjectFactory);
            initializeTestData();
        }
        [TestMethod] public void CreateTest() {
            o = ProductObjectFactory.Create(id, name, description, category, biddingEndDate);
            validateResults(id, name, description, category, biddingEndDate);
        }
    }
}
