using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Notification;
using Open.Domain.Notification;
namespace Open.Tests.Domain.Notification
{
    [TestClass]
    public class NewInsuranceNotificationTests : EntityBaseTests<NewInsuranceNotification, NewInsuranceNotificationData>
    {
        protected override NewInsuranceNotification getRandomObject()
        {
            createdWithNullArg = new NewInsuranceNotification(null);
            dbRecordType = typeof(NewInsuranceNotificationData);
            return GetRandom.Object<NewInsuranceNotification>();
        }
    }
}

