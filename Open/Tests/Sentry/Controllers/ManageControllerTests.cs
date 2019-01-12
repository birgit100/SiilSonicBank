using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Infra;
using Open.Sentry.Controllers;
namespace Open.Tests.Sentry.Controllers
{
    [TestClass]
    public class ManageControllerTests : AcceptanceTests<ApplicationDbContext>
    {
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(ManageController);
        }
        [TestMethod]
        public void IndexTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void SendVerificationEmailTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ChangePasswordTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void SetPasswordTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ExternalLoginsTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void LinkLoginTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void LinkLoginCallbackTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void RemoveLoginTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void TwoFactorAuthenticationTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void Disable2FaWarningTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void Disable2FaTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void EnableAuthenticatorTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ShowRecoveryCodesTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ResetAuthenticatorWarningTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ResetAuthenticatorTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void GenerateRecoveryCodesWarningTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void GenerateRecoveryCodesTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void StatusMessageTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        protected override void initializeDatabase(ApplicationDbContext context)
        {
            AspNetUserInitializer.Initialize(context);
        }
    }
}
