using System;
using System.Linq.Expressions;
using Auction.Bag;
using Auction.Data.Bacchus;
using Auction.Domain.Bacchus;
using Auction.Facade.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Bag {
    [TestClass] public class GetMemberTests : BaseTests {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(GetMember);
        }

        [TestMethod] public void NameTest() {
            Assert.AreEqual("DbRecord", GetMember.Name<BidObject>(o => o.DbRecord));
            Assert.AreEqual("Price", GetMember.Name<BidDbRecord>(o => o.Price));
            Assert.AreEqual("NameTest", GetMember.Name<GetMemberTests>(o => o.NameTest()));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Func<BidDbRecord, object>>)null));
            Assert.AreEqual(string.Empty, GetMember.Name((Expression<Action<BidDbRecord>>)null));
        }
        [TestMethod] public void DisplayNameTest() {
            Assert.AreEqual("DbRecord", GetMember.DisplayName<BidObject>(o => o.DbRecord));
            Assert.AreEqual("Valid From",
                GetMember.DisplayName<BidViewModel>(o => o.ValidFrom));
            Assert.AreEqual("User ID", GetMember.DisplayName<BidViewModel>(o => o.UserId));
            Assert.AreEqual("Price", GetMember.DisplayName<BidViewModel>(o => o.Price));
            Assert.AreEqual("Valid To", GetMember.DisplayName<BidViewModel>(o => o.ValidTo));
            Assert.AreEqual(string.Empty, GetMember.DisplayName<BidViewModel>(null));
            //Impossible to use for methods
            //Assert.AreEqual(string.Empty, GetMember.DisplayName<GetMemberTests>(o => o.NameTest()));
        }
    }
}


