﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests.Domain {
    [TestClass] public class IsDomainTested : AssemblyTests {
        private const string assembly = "Open.Domain";
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        [TestMethod] public void IsCommonTested() {
            isAllTested(assembly, Namespace("Common"));
        }
        [TestMethod] public void IsPartyTested() {
            isAllTested(assembly, Namespace("Party"));
        }
        [TestMethod] public void IsQuantityTested() {
            isAllTested(assembly, Namespace("Quantity"));
        }
        [TestMethod] public void IsBankTested() {
            isAllTested(assembly, Namespace("Bank"));
        }
        [TestMethod]
        public void IsNotificationTested()
        {
            isAllTested(assembly, Namespace("Notification"));
        }
        [TestMethod]
        public void IsTested()
        {
            isAllTested(base.Namespace("Domain"));
        }

    }
}



