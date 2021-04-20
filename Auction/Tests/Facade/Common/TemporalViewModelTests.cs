﻿using System;
using Auction.Bag;
using Auction.Core;
using Auction.Facade.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Auction.Tests.Facade.Common {
    [TestClass]
    public class TemporalViewModelTests : ViewModelTests<TemporalViewModel, RootObject> {
        class testClass : TemporalViewModel { }
        protected override TemporalViewModel getRandomTestObject() {
            return GetRandom.Object<testClass>();
        }

        [TestMethod] public void ValidFromTest() {
            DateTime? rnd() => GetRandom.DateTime(null, obj.ValidTo?.AddYears(-1));
            testReadWriteProperty(() => obj.ValidFrom, x => obj.ValidFrom = x, rnd);
        }
        [TestMethod] public void ValidToTest() {
            DateTime? rnd() => GetRandom.DateTime(obj.ValidFrom?.AddYears(1));
            testReadWriteProperty(() => obj.ValidTo, x => obj.ValidTo = x, rnd);
        }
    }
}

