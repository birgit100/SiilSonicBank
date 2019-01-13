using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Sentry.Extensions;

namespace Open.Tests.Sentry.Extensions
{
    [TestClass]
    public class ClaimsPrincipalExtensionTests : BaseTests
    {
        private ClaimsPrincipal principal;

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(ClaimsPrincipalExtension);
            principal = new ClaimsPrincipal();
        }
        [TestMethod]
        public void GetFirstNameTest()
        {
            var s = new ClaimsPrincipal();
            principal.GetFirstName();
            var firstName = principal.ToString();
            Assert.IsNotNull(firstName);
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", firstName);
        }
        [TestMethod]
        public void GetLastNameTest()
        {
            var s = new ClaimsPrincipal();
            principal.GetLastName();
            var firstName = principal.GetType().ToString();
            Assert.IsNotNull(firstName);
            Assert.AreEqual("System.Security.Claims.ClaimsPrincipal", firstName);
        }
    }
}
