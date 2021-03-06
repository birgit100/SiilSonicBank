﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Open.Tests.Infra {
    [TestClass] public class IsInfraTested : AssemblyTests {
        private const string assembly = "Open.Infra";
        protected override string Namespace(string name) {
            return $"{assembly}.{name}";
        }
        [TestMethod] public void IsPartyTested() {
            isAllTested(assembly, Namespace("Party"));
        }
        [TestMethod] public void IsQuantityTested() {
            isAllTested(assembly, Namespace("Quantity"));
        }
        [TestMethod]
        public void IsBankTested()
        {
            isAllTested(assembly, Namespace("Bank"));
        }
        [TestMethod]
        public void IsNotificationTested()
        {
            isAllTested(assembly, Namespace("Notification"));
        }
        [TestMethod] public void IsTested() {
            isAllTested(base.Namespace("Infra"));
        }
    }
}





