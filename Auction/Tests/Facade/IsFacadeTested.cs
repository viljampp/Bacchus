using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Auction.Tests.Facade {
    [TestClass] public class IsFacadeTested : AssemblyTests {
        private const string assembly = "Auction.Facade";
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        [TestMethod] public void IsBacchusTested() {
            isAllClassesTested(assembly, Namespace("Bacchus"));
        }
        [TestMethod] public void IsCommonTested() {
            isAllClassesTested(assembly, Namespace("Common"));
        }
        [TestMethod] public void IsComponentsTested() {
            isAllClassesTested(assembly, Namespace("Components"));
        }
    }
}


