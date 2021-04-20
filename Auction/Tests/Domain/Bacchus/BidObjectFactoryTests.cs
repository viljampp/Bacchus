using System;
using Auction.Bag;
using Auction.Core;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class BidObjectFactoryTests : BaseTests {
        private string id;
        private string productId;
        private string userId;
        private decimal price;
        private DateTime validFrom;
        private DateTime validTo;
        private BidObject o;
        private void initializeTestData() {
            var min = DateTime.Now.AddYears(-50);
            var max = DateTime.Now.AddYears(50);
            id = GetRandom.String();
            productId = GetRandom.String();
            userId = GetRandom.String();
            price = GetRandom.Decimal();
            validFrom = GetRandom.DateTime(min, max);
            validTo = GetRandom.DateTime(validFrom, max);
        }
        private void validateResults(string i = Constants.Unspecified,
            string n = Constants.Unspecified, string c = Constants.Unspecified,
            decimal? p = null, DateTime? f = null, DateTime? t = null) {
            Assert.AreEqual(i, o.DbRecord.ID);
            Assert.AreEqual(n, o.DbRecord.ProductId);
            Assert.AreEqual(c, o.DbRecord.UserId);
            Assert.AreEqual(p ?? Constants.DefaultPrize, o.DbRecord.Price);
            Assert.AreEqual(f ?? DateTime.MinValue, o.DbRecord.ValidFrom);
            Assert.AreEqual(t ?? DateTime.MaxValue, o.DbRecord.ValidTo);
        }
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(BidObjectFactory);
            initializeTestData();
        }
        [TestMethod] public void CreateTest() {
            o = BidObjectFactory.Create(id, userId, productId, price, validFrom, validTo);
            validateResults(id, productId, userId, price, validFrom, validTo);
        }
        [TestMethod] public void CreateValidFromGreaterThanValidToTest() {
            o = BidObjectFactory.Create(id, userId, productId, price, validTo, validFrom);
            validateResults(id, productId, userId, price, validFrom, validTo);
        }
        [TestMethod] public void CreateWithNullArgumentsTest() {
            o = BidObjectFactory.Create(null, null, null);
            validateResults();
        }
    }
}
