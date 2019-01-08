using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Notification;
namespace Open.Tests.Facade.Notification
{
    [TestClass]
    public class NewInsuranceNotificationViewTests : ObjectTests<NewInsuranceNotificationView>
    {
        protected override NewInsuranceNotificationView getRandomObject()
        {
            return GetRandom.Object<NewInsuranceNotificationView>();
        }
        [TestMethod]
        public void IsNotificationViewTest()
        {
            Assert.AreEqual(obj.GetType().BaseType, typeof(NotificationView));
        }
        [TestMethod]
        public void InsuranceTypeTest()
        {
            canReadWrite(() => obj.InsuranceType, x => obj.InsuranceType = x);
        }
        [TestMethod]
        public void ToStringTest()
        {
            var s = $"{obj.InsuranceType} {obj.Message} {obj.ValidTo}. ";
            Assert.AreEqual(s, obj.ToString());
        }
    }
}


