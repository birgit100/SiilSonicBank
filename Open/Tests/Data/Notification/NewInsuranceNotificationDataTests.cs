using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Notification;
namespace Open.Tests.Data.Notification
{
    [TestClass]
    public class NewInsuranceNotificationDataTests : ObjectTests<NewInsuranceNotificationData>
    {
        class testClass : NewInsuranceNotificationData { }
        protected override NewInsuranceNotificationData getRandomObject()
        {
            return GetRandom.Object<testClass>();
        }
        [TestMethod]
        public void IsInstanceOfNewTransactionNotificationData()
        {
            Assert.AreEqual(typeof(NotificationData), typeof(NewInsuranceNotificationData).BaseType);
        }
        [TestMethod]
        public void MessageTest()
        {
            canReadWrite(() => obj.Message, x => obj.Message = x);
            obj.Message = null;
            Assert.AreEqual("insurance is now valid until", obj.Message);
        }
        [TestMethod]
        public void InsuranceTypeTest()
        {
            canReadWrite(() => obj.InsuranceType, x => obj.InsuranceType = x);
        }
    }
}