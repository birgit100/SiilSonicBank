using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Notification;
using Open.Domain.Notification;
namespace Open.Tests.Domain.Notification
{
    [TestClass]
    public class RequestStatusNotificationTests : EntityBaseTests<RequestStatusNotification, RequestStatusNotificationData>
    {
        protected override RequestStatusNotification getRandomObject()
        {
            createdWithNullArg = new RequestStatusNotification(null);
            dbRecordType = typeof(RequestStatusNotificationData);
            return GetRandom.Object<RequestStatusNotification>();
        }
    }
}

