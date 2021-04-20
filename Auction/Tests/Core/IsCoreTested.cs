using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Core {
    [TestClass] public class IsCoreTested : AssemblyTests {
        [TestMethod] public void IsTested() {
            isAllClassesTested(Namespace("Core"));
        }
    }
}
