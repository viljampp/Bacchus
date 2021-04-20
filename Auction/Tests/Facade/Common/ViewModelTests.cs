using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Common {
    public abstract class ViewModelTests<TClass, TBaseClass> : ObjectTests<TClass> {
        [TestMethod] public void BaseClassTest() {
            Assert.IsInstanceOfType(obj, typeof(TBaseClass));
        }
    }
}
