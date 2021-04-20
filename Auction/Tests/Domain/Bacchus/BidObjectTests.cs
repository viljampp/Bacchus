using Auction.Bag;
using Auction.Data.Bacchus;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class BidObjectTests : ObjectTests<BidObject> {
        protected override BidObject getRandomTestObject() {
            return GetRandom.Object<BidObject>();
        }

        [TestMethod] public void DbRecordTest() {
            var r = GetRandom.Object<BidDbRecord>();
            obj = new BidObject(r);
            Assert.AreSame(r, obj.DbRecord);
        }
        [TestMethod] public void CanCreateWithNullTest() {
            obj = new BidObject(null);
            Assert.IsNotNull(obj);
            Assert.IsNotNull(obj.DbRecord);
        }

        [TestMethod] public void DbRecordIsReadOnlyTest() {
            var name = GetMember.Name<BidObject>(x => x.DbRecord);
            Assert.IsTrue(IsReadOnly.Field<BidObject>(name));
        }
    }
}
