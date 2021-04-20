using Auction.Bag;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Bag {

    [TestClass] public class SystemStringTests : BaseTests
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(SystemString);
        }
        [TestMethod] public void StartsWithLetterTest() {
            Assert.IsTrue(SystemString.StartsWithLetter("abc"));
            Assert.IsFalse(SystemString.StartsWithLetter("1abc"));
            Assert.IsFalse(SystemString.StartsWithLetter(""));
            Assert.IsFalse(SystemString.StartsWithLetter(null));
        }

        [TestMethod] public void ToBackwardsTest() {
            Assert.AreEqual("cba", SystemString.ToBackwards("abc"));
            Assert.AreEqual("    ", SystemString.ToBackwards("    "));
            Assert.AreEqual("", SystemString.ToBackwards(""));
            Assert.AreEqual("", SystemString.ToBackwards(null));
        }

    }

}



