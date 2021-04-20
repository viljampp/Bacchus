using System;
using Auction.Bag;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Bag {
    [TestClass] public class ToTheSequenceTests: BaseTests {
        [TestInitialize] public override void TestInitialize() {
            base.TestInitialize();
            type = typeof(ToTheSequence);
        }
        [TestMethod] public void OfGrowingTest() {
            doOfGrowingTest(DateTime.MaxValue, DateTime.MinValue);
            doOfGrowingTest(double.MaxValue, double.MinValue);
            doOfGrowingTest(int.MaxValue, int.MinValue);
        }
        private static void doOfGrowingTest<T>(T maxValue, T minValue) where T : IComparable {
            Assert.IsTrue(maxValue.CompareTo(minValue) >= 0);
            ToTheSequence.OfGrowing(ref maxValue, ref minValue);
            Assert.IsTrue(maxValue.CompareTo(minValue) <= 0);
        }
    }
}


