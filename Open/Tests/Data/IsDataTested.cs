﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests.Data {
    [TestClass] public class IsDataTested : AssemblyTests {
        private const string assembly = "Open.Data";
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
            isAllTested(base.Namespace("Data"));
        }
    }
}





