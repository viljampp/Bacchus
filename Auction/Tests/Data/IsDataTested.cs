using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Data {
    [TestClass] public class IsDataTested : AssemblyTests {
        private const string assembly = "Auction.Data";
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        [TestMethod] public void IsQuantityTested() {
            isAllClassesTested(assembly, Namespace("Bacchus"));
        }
        [TestMethod] public void IsCommonTested() {
            isAllClassesTested(assembly, Namespace("Common"));
        }
    }
}





