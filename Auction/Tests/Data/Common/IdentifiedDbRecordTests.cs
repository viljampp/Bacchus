using Auction.Bag;
using Auction.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Data.Common {
    [TestClass] public class IdentifiedDbRecordTests : ObjectTests<IdentifiedDbRecord> {
        private class testClass : IdentifiedDbRecord { }
        protected override IdentifiedDbRecord getRandomTestObject() {
            return GetRandom.Object<testClass>();
        }
        [TestMethod] public void IsAbstract() {
            Assert.IsTrue(typeof(IdentifiedDbRecord).IsAbstract);
        }
        [TestMethod] public void BaseTypeIsUniqueDbRecord() {
            Assert.AreEqual(typeof(UniqueDbRecord), typeof(IdentifiedDbRecord).BaseType);
        }
        [TestMethod] public void IDTest() {
            testReadWriteProperty(() => obj.ID, x => obj.ID = x);
            testNullEmptyAndWhitespaceCases(() => obj.ID, x => obj.ID = x, () => obj.ID);
        }
    }
}







