using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Data.Notification;
using Open.Domain.Notification;
using Open.Facade.Bank;
using Open.Facade.Common;
using Open.Facade.Notification;
using Open.Infra;
using Open.Infra.Notification;
using Open.Sentry.Controllers;
namespace Open.Tests.Sentry.Controllers
{

    [TestClass]
    public class
        NotificationControllerTests : ControllerTests<ApplicationDbContext, NotificationsController, INotification, NotificationData>
    {
        private static ApplicationUser aspNetUser;
        private static AccountData account;

        [TestInitialize]
        public override void TestInitialize()
        {
            addAspNetUser(GetRandom.String());
            base.TestInitialize();
            repository = new NotificationsRepository(db);
            controller = "notifications";
        }
        protected static void addAspNetUser(string id)
        {
            aspNetUser = new ApplicationUser { Id = id };
            db.Users.Add(aspNetUser);
            db.SaveChanges();
            addAccount(id);
        }
        protected static void addAccount(string aspnetId)
        {
            account = new AccountData { ID = GetRandom.String(), AspNetUserId = aspnetId };
            db.Accounts.Add(account);
            db.SaveChanges();
        }
        protected List<string> specificStringsToTestInIndexView()
        {
            return new List<string> {
                "<h2>Your notifications</h2>",
                "<th><a href=\"/payments?SortOrder=validFrom\">Sent at</a></th>",
                "<th><a href=\"/payments?SortOrder=senderAccount\">Sent From</a></th>",
                "<th><a href=\"/payments?SortOrder=message\">Message</a></th>",
            };
        }
        protected override async Task validateEntityInRepository(object o)
        {
            var expected = o as EntityView;
            var actual = await repository.GetObject(expected?.ID);
            switch (o)
            {
                case NewInsuranceNotificationView ins:
                    validateEntity(ins, (actual as NewInsuranceNotification)?.Data);
                    break;
                case RequestStatusNotificationView reqSta:
                    validateEntity(reqSta, (actual as RequestStatusNotification)?.Data);
                    break;
                case NewRequestTransactionNotificationView newReq:
                    validateEntity(newReq, (actual as NewRequestTransactionNotification)?.Data);
                    break;
                case NewTransactionNotificationView newTra:
                    validateEntity(newTra, (actual as NewTransactionNotification)?.Data);
                    break;
                case WelcomeNotificationView wel:
                    validateEntity(wel, (actual as WelcomeNotification)?.Data);
                    break;
                default:
                    Assert.Fail($"Wrong type {o.GetType()}");
                    break;
            }
        }
        protected override IEnumerable<KeyValuePair<string, string>>
            createHttpPostContext(object o)
        {
            switch (o)
            {
                case NewInsuranceNotificationView ins:
                    return httpPostContext(ins);
                case RequestStatusNotificationView reqSta:
                    return httpPostContext(reqSta);
                case NewRequestTransactionNotificationView newReq:
                    return httpPostContext(newReq);
                case NewTransactionNotificationView newTra:
                    return httpPostContext(newTra);
                case WelcomeNotificationView wel:
                    return httpPostContext(wel);
                default: return new Dictionary<string, string>();

            }
        }
        private void validateEntity(NewInsuranceNotificationView expected, NewInsuranceNotificationData actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Message, actual.Message);
            Assert.AreEqual(expected.SenderAccountId, actual.SenderId);
            Assert.AreEqual(expected.ReceiverAccountId, actual.ReceiverId);
            Assert.AreEqual(expected.IsSeen, actual.IsSeen);
            Assert.AreEqual(expected.InsuranceType, actual.InsuranceType);
            validateDates(expected.ValidFrom, actual.ValidFrom);
            validateDates(expected.ValidTo, actual.ValidTo);
        }
        private void validateEntity(RequestStatusNotificationView expected, RequestStatusNotificationData actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Message, actual.Message);
            Assert.AreEqual(expected.SenderAccountId, actual.SenderId);
            Assert.AreEqual(expected.ReceiverAccountId, actual.ReceiverId);
            Assert.AreEqual(expected.IsSeen, actual.IsSeen);
            Assert.AreEqual(expected.Status, actual.Status);
            validateDates(expected.ValidFrom, actual.ValidFrom);
            validateDates(expected.ValidTo, actual.ValidTo);
        }
        private void validateEntity(NewRequestTransactionNotificationView expected, NewRequestTransactionNotificationData actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Message, actual.Message);
            Assert.AreEqual(expected.SenderAccountId, actual.SenderId);
            Assert.AreEqual(expected.ReceiverAccountId, actual.ReceiverId);
            Assert.AreEqual(expected.IsSeen, actual.IsSeen);
            validateDates(expected.ValidFrom, actual.ValidFrom);
            validateDates(expected.ValidTo, actual.ValidTo);
        }
        private void validateEntity(NewTransactionNotificationView expected, NewTransactionNotificationData actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Message, actual.Message);
            Assert.AreEqual(expected.SenderAccountId, actual.SenderId);
            Assert.AreEqual(expected.ReceiverAccountId, actual.ReceiverId);
            Assert.AreEqual(expected.IsSeen, actual.IsSeen);
            Assert.AreEqual(expected.Amount, actual.Amount);
            validateDates(expected.ValidFrom, actual.ValidFrom);
            validateDates(expected.ValidTo, actual.ValidTo);
        }
        private void validateEntity(WelcomeNotificationView expected, WelcomeNotificationData actual)
        {
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.ID);
            Assert.AreEqual(expected.Message, actual.Message);
            Assert.AreEqual(expected.SenderAccountId, actual.SenderId);
            Assert.AreEqual(expected.ReceiverAccountId, actual.ReceiverId);
            Assert.AreEqual(expected.IsSeen, actual.IsSeen);
            validateDates(expected.ValidFrom, actual.ValidFrom);
            validateDates(expected.ValidTo, actual.ValidTo);
        }
        private static IEnumerable<KeyValuePair<string, string>> httpPostContext(
            NewInsuranceNotificationView o)
        {
            var d = new Dictionary<string, string> {
                {GetMember.Name<NewInsuranceNotificationView>(m => m.ID), o?.ID},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.Message), o?.Message},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.SenderAccountId), o?.SenderAccountId},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.ReceiverAccountId), o?.ReceiverAccountId},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.IsSeen.ToString()), o?.IsSeen.ToString()},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.InsuranceType), o?.InsuranceType},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.ValidFrom), o?.ValidFrom.ToString()},
                {GetMember.Name<NewInsuranceNotificationView>(m => m.ValidTo), o?.ValidTo.ToString()}
            };
            return d;
        }
        private static IEnumerable<KeyValuePair<string, string>> httpPostContext(
            RequestStatusNotificationView o)
        {
            var d = new Dictionary<string, string> {
                {GetMember.Name<RequestStatusNotificationView>(m => m.ID), o?.ID},
                {GetMember.Name<RequestStatusNotificationView>(m => m.Message), o?.Message},
                {GetMember.Name<RequestStatusNotificationView>(m => m.SenderAccountId), o?.SenderAccountId},
                {GetMember.Name<RequestStatusNotificationView>(m => m.ReceiverAccountId), o?.ReceiverAccountId},
                {GetMember.Name<RequestStatusNotificationView>(m => m.IsSeen.ToString()), o?.IsSeen.ToString()},
                {GetMember.Name<RequestStatusNotificationView>(m => m.Status.ToString()), o?.Status.ToString()},
                {GetMember.Name<RequestStatusNotificationView>(m => m.ValidFrom), o?.ValidFrom.ToString()},
                {GetMember.Name<RequestStatusNotificationView>(m => m.ValidTo), o?.ValidTo.ToString()}
            };
            return d;
        }
        private static IEnumerable<KeyValuePair<string, string>> httpPostContext(
            NewRequestTransactionNotificationView o)
        {
            var d = new Dictionary<string, string> {
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.ID), o?.ID},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.Message), o?.Message},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.SenderAccountId), o?.SenderAccountId},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.ReceiverAccountId), o?.ReceiverAccountId},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.IsSeen.ToString()), o?.IsSeen.ToString()},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.ValidFrom), o?.ValidFrom.ToString()},
                {GetMember.Name<NewRequestTransactionNotificationView>(m => m.ValidTo), o?.ValidTo.ToString()}
            };
            return d;
        }
        private static IEnumerable<KeyValuePair<string, string>> httpPostContext(
            NewTransactionNotificationView o)
        {
            var d = new Dictionary<string, string> {
                {GetMember.Name<NewTransactionNotificationView>(m => m.ID), o?.ID},
                {GetMember.Name<NewTransactionNotificationView>(m => m.Message), o?.Message},
                {GetMember.Name<NewTransactionNotificationView>(m => m.SenderAccountId), o?.SenderAccountId},
                {GetMember.Name<NewTransactionNotificationView>(m => m.ReceiverAccountId), o?.ReceiverAccountId},
                {GetMember.Name<NewTransactionNotificationView>(m => m.IsSeen.ToString()), o?.IsSeen.ToString()},
                {GetMember.Name<NewTransactionNotificationView>(m => m.Amount.ToString()), o?.Amount.ToString()},
                {GetMember.Name<NewTransactionNotificationView>(m => m.ValidFrom), o?.ValidFrom.ToString()},
                {GetMember.Name<NewTransactionNotificationView>(m => m.ValidTo), o?.ValidTo.ToString()}
            };
            return d;
        }
        private static IEnumerable<KeyValuePair<string, string>> httpPostContext(
            WelcomeNotificationView o)
        {
            var d = new Dictionary<string, string> {
                {GetMember.Name<WelcomeNotificationView>(m => m.ID), o?.ID},
                {GetMember.Name<WelcomeNotificationView>(m => m.Message), o?.Message},
                {GetMember.Name<WelcomeNotificationView>(m => m.SenderAccountId), o?.SenderAccountId},
                {GetMember.Name<WelcomeNotificationView>(m => m.ReceiverAccountId), o?.ReceiverAccountId},
                {GetMember.Name<WelcomeNotificationView>(m => m.IsSeen.ToString()), o?.IsSeen.ToString()},
                {GetMember.Name<WelcomeNotificationView>(m => m.ValidFrom), o?.ValidFrom.ToString()},
                {GetMember.Name<WelcomeNotificationView>(m => m.ValidTo), o?.ValidTo.ToString()}
            };
            return d;
        }
        protected object createRandomViewModel()
        {
            var v = GetRandom.Object<InsuranceView>();
            v.ValidTo = GetRandom.DateTime(v.ValidFrom);
            v.AccountId = account.ID;
            v.Account = account;
            return v;
        }

        protected override string createDbRecord()
        {
            var r = GetRandom.Object<AccountData>();
            db.Accounts.Add(r);
            db.SaveChanges();
            specificStringsToTestInView = new List<string> {
                $"{r.ID}",
                $"{r.Type}",
                $"{r.Balance?.ToString(CultureInfo.CurrentCulture)}",
                $"{r.ValidFrom.Date:dd/MM/yyyy}"
            };
            return r.ID;
        }
        protected override void initializeDatabase(ApplicationDbContext context)
        {
            AspNetUserInitializer.Initialize(context);
        }
        [TestMethod]
        public async Task IndexTest()
        {
            var a = GetUrl.ForControllerAction<InsuranceController>(x => x.Index(aspNetUser.Id, null, null, null, null));
            await testWhenLoggedOut(a, HttpStatusCode.Unauthorized);
            var strings = new List<string> {
                $"<form method=\"get\" action=\"/{controller}\"",
                "<div class=\"form-inline col-md-6\">",
                "Find by: <input class=\"form-control\" type=\"text\" name=\"SearchString\"",
                "<input type=\"submit\" value=\"Search\" class=\"btn btn-default\" /> |",
                $"<a href=\"/{controller}\">Back to Full List</a>",
                "<table class=\"table\">",
                "<thead>",
                $"<a class=\"btn btn-default disabled\" href=\"/{controller}?page=0\">",
                $"<a class=\"btn btn-default \" href=\"/{controller}?page=2\">"
            };
            strings.AddRange(specificStringsToTestInIndexView());
            await testWhenLoggedIn(a, strings.ToArray());
        }


        [TestMethod]
        public async Task CreateAllGivenTest()
        {
            //Assert.Inconclusive();
            await createAllGivenTest<BankAccountController>(createRandomViewModel, x => x.Create());
        }
        [TestMethod]
        public void ChangeSeenStatusTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ChangeSeenStatusTrueForAllTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void DeleteTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ViewNotificationTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
    }
}
