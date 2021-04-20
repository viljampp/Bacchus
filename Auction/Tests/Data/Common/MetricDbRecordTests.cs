using Auction.Bag;
using Auction.Data.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Data.Common {
    [TestClass] public class MetricDbRecordTests : ObjectTests<MetricDbRecord> {
        private class testClass : MetricDbRecord { }
        protected override MetricDbRecord getRandomTestObject() {
            return GetRandom.Object<testClass>();
        }
        [TestMethod] public void IsAbstract() {
            Assert.IsTrue(typeof(MetricDbRecord).IsAbstract);
        }
        [TestMethod] public void BaseTypeIsRootObjectDbRecord() {
            Assert.AreEqual(typeof(IdentifiedDbRecord), typeof(MetricDbRecord).BaseType);
        }
    }
}


