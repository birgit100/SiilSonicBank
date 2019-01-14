using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Data.Bank;
using Open.Domain.Bank;
using Open.Facade.Bank;
using Open.Infra;
using Open.Infra.Bank;
using Open.Sentry.Controllers;
namespace Open.Tests.Sentry.Controllers
{

    [TestClass]
    public class
        BankAccountControllerTests : ControllerTests<ApplicationDbContext, BankAccountController, Account, AccountData>
    {

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            repository = new AccountRepository(db);
            controller = "bankaccount";
            detailsViewCaption = "account";
            actualEditAction = "renew";
            editViewCaption = detailsViewCaption;
        }

        protected List<string> specificStringsToTestInIndexView()
        {
            return new List<string> {
                "<h2>Payments</h2>",
                "<a href=\"/BankAccount/Create\">Create new account &raquo</a>",
                "<th>Account Number</th>",
                "<th>Type</th>",
                "<th>Balance</th>",
                "<th>Status</th>",
                "<th>Valid To</th>",
            };
        }

        protected async Task statusIsInactive(string id)
        {
            var r = await repository.GetObject(id);
            Assert.AreEqual(r.Data.Status, "Inactive");
        }

        protected override async Task validateEntityInRepository(object o)
        {
            var expected = o as AccountView;
            var actual = await repository.GetObject(expected?.ID);
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.Data.ID);
            Assert.AreEqual(expected.AspNetUserId, actual.Data.AspNetUserId);
            Assert.AreEqual(expected.Balance, actual.Data.Balance);
            Assert.AreEqual(expected.Status, actual.Data.Status);
            Assert.AreEqual(expected.Type, actual.Data.Type);
            validateDates(expected.ValidFrom, actual.Data.ValidFrom);
            validateDates(expected.ValidTo, actual.Data.ValidTo);
        }

        protected override IEnumerable<KeyValuePair<string, string>>
            createHttpPostContext(object o)
        {

            var c = o as AccountView;
            var d = new Dictionary<string, string> {
                {GetMember.Name<AccountView>(m => m.ID), c?.ID}, {
                    GetMember.Name<AccountView>(m => m.Balance),
                    c?.Balance?.ToString(CultureInfo.InvariantCulture)
                },
                {GetMember.Name<AccountView>(m => m.AspNetUserId), c?.AspNetUserId},
                {GetMember.Name<AccountView>(m => m.Status), c?.Status},
                {GetMember.Name<AccountView>(m => m.Type), c?.Type},
                {GetMember.Name<AccountView>(m => m.ValidFrom), c?.ValidFrom.ToString()},
                {GetMember.Name<AccountView>(m => m.ValidTo), c?.ValidTo.ToString()},
            };
            return d;
        }

        protected object createRandomViewModel()
        {
            var v = GetRandom.Object<AccountView>();
            v.ValidTo = GetRandom.DateTime(v.ValidFrom);
            addAspNetUser(v.AspNetUserId);
            v.AspNetUser = db.Users.Find(v.AspNetUserId);
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
            DbInitializer.Initialize(context);
        }
        protected static void addAspNetUser(string id)
        {
            db.Users.Add(new ApplicationUser { Id = id });
            db.SaveChanges();
        }
        [TestMethod]
        public async Task CreateTest()
        {
            await createTest(x => x.Create(), controller, "New account");
        }
        [TestMethod]
        public async Task DeactivateTest()
        {
            var id = createDbRecord();
            await deactivateTest(id);
        }
        protected async Task createTest(Expression<Func<BankAccountController, object>> action,
            string controllerName,
            string header, string postAction = "create")
        {
            var a = GetUrl.ForControllerAction(action);
            await testWhenLoggedOut(a, HttpStatusCode.Unauthorized);
            await testWhenLoggedIn(a,
                "<h2>Create</h2>",
                $"<form action=\"/{controllerName}/{postAction}\" method=\"post\">",
                $"<h4>{header}</h4>",
                "<input type=\"submit\" value=Create &raquo class=\"btn btn-primary btn-sm\" />",
                $"<a href=\"/\">Back</a>"
            );            


        }
        private async Task deactivateTest(string id)
        {
            var a = GetUrl.ForControllerAction<BankAccountController>(x => x.Deactivate(""));
            a = a + $"/{id}";
            await testWhenLoggedOut(a, HttpStatusCode.Unauthorized);
            var strings = new List<string> {
                "<h2>Deactivate</h2>",
                $"<form action=\"/{controller}/deactivate/{id}\" method=\"post\">",
                $"<h4>{id}</h4>",
                "<input type=\"submit\" value=Deactivate &raquo class=\"btn btn-primary btn-sm\" />",
                $"<a href=\"/\">Back to home page</a>"
            };
            strings.AddRange(specificStringsToTestInView);
            await testWhenLoggedIn(a, strings.ToArray());
        }     
        [TestMethod]
        public async Task DeactivateConfirmedTest()
        {
            var id = createDbRecord();
            await deactivateTest(id);
            var a = GetUrl.ForControllerAction<BankAccountController>(x => x.Deactivate(""));
            a = a + $"/{id}";
            AuthenticationHandlerTest.IsLoggedIn = true;
            var response = await client.GetAsync(a);
            response.EnsureSuccessStatusCode();
            var d = new Dictionary<string, string> {
                {"ID", id}
            };
            var content = new FormUrlEncodedContent(d);
            AuthenticationHandlerTest.IsLoggedIn = true;
            response = await client.PostAsync(a, content);
            Assert.AreEqual(HttpStatusCode.Redirect, response.StatusCode);
            await statusIsInactive(id);
        }
        [TestMethod]
        public async Task RenewTest() {
            await renewTest(x => x.Renew(""), () => actualEditAction, () => editViewCaption, () => specificStringsToTestInView);
        }
        protected async Task renewTest(Expression<Func<BankAccountController, object>> actionMethod, Func<string> actionName,
            Func<string> header, Func<List<string>> stringsToTestInView)
        {
            var id = createDbRecord();
            var a = GetUrl.ForControllerAction(actionMethod);
            a = a + $"/{id}";
            await testWhenLoggedOut(a, HttpStatusCode.Unauthorized);
            var strings = new List<string> {
                "<h2>Renew</h2>",
                $"<form action=\"/{controller}/{actionName()}/{id}\" method=\"post\">",
                $"<h4>{id}</h4>",
                "<input type=\"submit\" value=Renew &raquo class=\"btn btn-primary btn-sm\" />",
                $"<a href=\"/\">Back to home page</a>"
            };
            strings.AddRange(stringsToTestInView());
            await testWhenLoggedIn(a, strings.ToArray());
        }
        [TestMethod]
        public void CreateAllGivenTest()
        {
            Assert.Inconclusive();
            //await createAllGivenTest<BankAccountController>(createRandomViewModel, x => x.Create());
        }
    }
}
