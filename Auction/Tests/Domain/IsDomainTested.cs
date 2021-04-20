using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Domain {
    [TestClass] public class IsDomainTested : AssemblyTests {
        private const string assembly = "Auction.Domain";
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        [TestMethod] public void IsLocationTested() {
            isAllClassesTested(assembly, Namespace("Bacchus"));
        }
    }
}



