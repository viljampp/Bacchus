

using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests {
    public class ClassTests<T> : BaseTests {
        [TestInitialize] public override void TestInitialize() {
            type = typeof(T);
        }
    }
}




