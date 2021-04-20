using System.Globalization;
using Auction.Bag;
using Auction.Data.Bacchus;
using Auction.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Data.Bacchus {
    [TestClass] public class BidDbRecordTests : ObjectTests<BidDbRecord> {
        protected override BidDbRecord getRandomTestObject() {
            return GetRandom.Object<BidDbRecord>();
        }
        [TestMethod] public void BaseTypeIsIdentifiedDbRecord() {
            Assert.AreEqual(typeof(UniqueDbRecord), typeof(BidDbRecord).BaseType);
        }
        [TestMethod] public void UserIdTest() {
            testReadWriteProperty(() => obj.UserId, x => obj.UserId = x);
        }
        [TestMethod] public void ProductIdTest() {
            testReadWriteProperty(() => obj.ProductId, x => obj.ProductId = x);
        }
        [TestMethod] public void PriceTest() {
            testReadWriteProperty(() => obj.Price, x => obj.Price = x);
        }

        [TestMethod] public void ContainsTest() {
            Assert.IsFalse(obj.Contains(GetRandom.String()));
            Assert.IsTrue(obj.Contains(string.Empty));
            Assert.IsTrue(obj.Contains(null));
            Assert.IsTrue(obj.Contains(obj.ID));
            Assert.IsTrue(obj.Contains(obj.ProductId));
            Assert.IsTrue(obj.Contains(obj.UserId));
            Assert.IsTrue(obj.Contains(obj.Price.ToString(CultureInfo.InvariantCulture)));
            Assert.IsTrue(obj.Contains(obj.ValidFrom.Year.ToString()));
            Assert.IsTrue(obj.Contains(obj.ValidFrom.Day.ToString()));
            Assert.IsTrue(obj.Contains(obj.ValidFrom.Month.ToString()));
            Assert.IsTrue(obj.Contains(obj.ValidTo.Year.ToString()));
            Assert.IsTrue(obj.Contains(obj.ValidTo.Day.ToString()));
            Assert.IsTrue(obj.Contains(obj.ValidTo.Month.ToString()));
        }
    }
}




