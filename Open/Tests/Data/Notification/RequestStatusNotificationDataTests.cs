using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Notification;
namespace Open.Tests.Data.Notification
{
    [TestClass]
    public class RequestStatusNotificationDataTests : ObjectTests<RequestStatusNotificationData>
    {
        class testClass : RequestStatusNotificationData { }
        protected override RequestStatusNotificationData getRandomObject()
        {
            return GetRandom.Object<testClass>();
        }
        [TestMethod]
        public void IsInstanceOfNewTransactionNotificationData()
        {
            Assert.AreEqual(typeof(NewRequestTransactionNotificationData), typeof(RequestStatusNotificationData).BaseType);
        }
        [TestMethod]
        public void MessageTest()
        {
            canReadWrite(() => obj.Message, x => obj.Message = x);
            obj.Message = null;
            obj.Status = TransactionStatus.Confirmed;
            Assert.AreEqual("has confirmed your request for a transaction in the amount of", obj.Message);
        }
        [TestMethod]
        public void StatusTest()
        {
            canReadWrite(() => obj.Status, x => obj.Status = x);
        }
    }
}