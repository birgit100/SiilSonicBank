using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Facade.Notification;
namespace Open.Tests.Facade.Notification
{
    [TestClass]
    public class RequestStatusNotificationViewTests : ObjectTests<RequestStatusNotificationView>
    {
        protected override RequestStatusNotificationView getRandomObject()
        {
            return GetRandom.Object<RequestStatusNotificationView>();
        }
        [TestMethod]
        public void IsNewRequestTransactionNotificationViewTest()
        {
            Assert.AreEqual(obj.GetType().BaseType, typeof(NewRequestTransactionNotificationView));
        }
        [TestMethod]
        public void StatusTest()
        {
            canReadWrite(() => obj.Status, x => obj.Status = x);
        }
    }
}


