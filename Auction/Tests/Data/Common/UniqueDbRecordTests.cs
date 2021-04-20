using Auction.Bag;
using Auction.Core;
using Auction.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Data.Common {
    [TestClass] public class UniqueDbRecordTests : ObjectTests<UniqueDbRecord> {
        private class testClass : UniqueDbRecord { }
        protected override UniqueDbRecord getRandomTestObject() {
            return GetRandom.Object<testClass>();
        }

        [TestMethod] public void IsAbstract() { Assert.IsTrue(typeof(UniqueDbRecord).IsAbstract); }

        [TestMethod] public void BaseTypeIsTemporalDbRecord() {
            Assert.AreEqual(typeof(TemporalDbRecord), typeof(UniqueDbRecord).BaseType);
        }

        [TestMethod] public void IDTest() {
            testReadWriteProperty(() => obj.ID, x => obj.ID = x);
            testNullEmptyAndWhitespaceCases(() => obj.ID, x => obj.ID = x, () => obj.ID);
        }

    }
}



