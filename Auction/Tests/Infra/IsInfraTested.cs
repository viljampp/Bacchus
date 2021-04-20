using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Infra {
    [TestClass] public class IsInfraTested : AssemblyTests {
        private const string assembly = "Auction.Infra";

        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }

        [TestMethod] public void IsLocationTested() {
            isAllClassesTested(assembly, Namespace("Bacchus"));
        }
    }
}
