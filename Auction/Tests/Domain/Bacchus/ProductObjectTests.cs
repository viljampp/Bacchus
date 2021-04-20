using Auction.Bag;
using Auction.Domain.Bacchus;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Domain.Bacchus {
    [TestClass] public class ProductObjectTests : ObjectTests<ProductObject> {
        protected override ProductObject getRandomTestObject() {
            return GetRandom.Object<ProductObject>();
        }
        [TestMethod] public void IdTest() {
            testReadWriteProperty(() => obj.Id, x => obj.Id = x);
        }
        [TestMethod] public void NameTest() {
            testReadWriteProperty(() => obj.Name, x => obj.Name = x);
        }
        [TestMethod] public void DescriptionTest() {
            testReadWriteProperty(() => obj.Description, x => obj.Description = x);
        }
        [TestMethod] public void CategoryTest() {
            testReadWriteProperty(() => obj.Category, x => obj.Category = x);
        }
        [TestMethod] public void BiddingEndDateTest() {
            testReadWriteProperty(() => obj.BiddingEndDate, x => obj.BiddingEndDate = x);
        }
    }
}
