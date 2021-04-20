using Auction.Bag;
using Auction.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Common {
    [TestClass]
    public class NamedViewModelTests : ViewModelTests<NamedViewModel, TemporalViewModel> {
        class testClass : NamedViewModel { }
        protected override NamedViewModel getRandomTestObject() {
            return GetRandom.Object<testClass>();
        }
        [TestMethod] public void IDTest() {
            testReadWriteProperty(() => obj.ID, x => obj.ID = x);
        }
    }
}



