using System;
using Auction.Bag;
using Auction.Core;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Bacchus {
    [TestClass] public class BidViewModelFactoryTests : BaseTests {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(BidViewModelFactory);
        }

        [TestMethod] public void CreateTest() {
            var o = GetRandom.Object<BidObject>();
            var v = BidViewModelFactory.Create(o);
            Assert.AreEqual(v.ProductId, o.DbRecord.ProductId);
            Assert.AreEqual(v.ValidFrom, o.DbRecord.ValidFrom);
            Assert.AreEqual(v.ValidTo, o.DbRecord.ValidTo);
            Assert.AreEqual(v.UserId, o.DbRecord.UserId);
            Assert.AreEqual(v.Price, o.DbRecord.Price);
            Assert.AreEqual(v.ID, o.DbRecord.ID);
        }

        [TestMethod] public void CreateNullTest() {
            var v = BidViewModelFactory.Create(null);
            Assert.AreEqual(v.ProductId, Constants.Unspecified);
            Assert.AreEqual(v.ValidFrom, null);
            Assert.AreEqual(v.ValidTo, null);
            Assert.AreEqual(v.UserId, Constants.Unspecified);
            Assert.AreEqual(v.Price, Constants.DefaultPrize);
            Assert.AreEqual(v.ID, Constants.Unspecified);
        }
        [TestMethod] public void CreateWithExtremumDatesTest() {
            var o = GetRandom.Object<BidObject>();
            o.DbRecord.ValidFrom = DateTime.MinValue;
            o.DbRecord.ValidTo = DateTime.MaxValue;
            var v = BidViewModelFactory.Create(o);
            Assert.AreEqual(v.ProductId, o.DbRecord.ProductId);
            Assert.AreEqual(v.ValidFrom, null);
            Assert.AreEqual(v.ValidTo, null);
            Assert.AreEqual(v.UserId, o.DbRecord.UserId);
            Assert.AreEqual(v.Price, o.DbRecord.Price);
            Assert.AreEqual(v.ID, o.DbRecord.ID);
        }
    }
}
