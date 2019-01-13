using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Net;
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
        InsuranceControllerTests : ControllerTests<ApplicationDbContext, InsuranceController, Insurance, InsuranceData> {
        private static ApplicationUser aspNetUser;
        private static AccountData account;
        [TestInitialize]
        public override void TestInitialize()
        {
            addAspNetUser(GetRandom.String());
            base.TestInitialize();
            repository = new InsuranceRepository(db);
            controller = "insurance";
        }

        protected List<string> specificStringsToTestInIndexView()
        {
            return new List<string> {
                "<h2>Your insurances</h2>",
                "<a href=\"/Insurance/Create\">New account &raquo</a>",
                "<th><a href=\"/payments?SortOrder=validFrom\">Valid From</a></th>",
                "<th><a href=\"/payments?SortOrder=validTo\">Valid To</a></th>",
                "<th><a href=\"/payments?SortOrder=accountId\">Bank account number</a></th>",
                "<th><a href=\"/payments?SortOrder=type\">Type</a></th>",
                "<th><a href=\"/payments?SortOrder=payment\">Payment</a></th>",
                "<th><a href=\"/payments?SortOrder=status\">Status</a></th>"
            };
        }
        protected override async Task validateEntityInRepository(object o)
        {
            var expected = o as InsuranceView;
            var actual = await repository.GetObject(expected?.ID);
            Assert.IsNotNull(expected);
            Assert.IsNotNull(actual);
            Assert.AreEqual(expected.ID, actual.Data.ID);
            Assert.AreEqual(expected.AccountId, actual.Data.AccountId);
            Assert.AreEqual(expected.Payment, actual.Data.Payment);
            Assert.AreEqual(expected.Status, actual.Data.Status);
            Assert.AreEqual(expected.Type, actual.Data.Type);
            validateDates(expected.ValidFrom, actual.Data.ValidFrom);
            validateDates(expected.ValidTo, actual.Data.ValidTo);
        }
        protected override IEnumerable<KeyValuePair<string, string>>
            createHttpPostContext(object o)
        {
            var c = o as InsuranceView;
            var d = new Dictionary<string, string> {
                {GetMember.Name<AccountView>(m => m.ID), c?.ID}, {
                    GetMember.Name<AccountView>(m => m.Balance),
                    c?.Payment?.ToString(CultureInfo.InvariantCulture)
                },
                {GetMember.Name<AccountView>(m => m.AspNetUserId), c?.AccountId},
                {GetMember.Name<AccountView>(m => m.Status), c?.Status},
                {GetMember.Name<AccountView>(m => m.Type), c?.Type},
                {GetMember.Name<AccountView>(m => m.ValidFrom), c?.ValidFrom.ToString()},
                {GetMember.Name<AccountView>(m => m.ValidTo), c?.ValidTo.ToString()},
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
            var r = GetRandom.Object<InsuranceData>();
            r.AccountId = account.ID;
            db.Insurances.Add(r);
            db.SaveChanges();
            specificStringsToTestInView = new List<string> {
                $"{r.ID}",
                $"{r.ValidFrom.Date:dd/MM/yyyy}",
                $"{r.ValidTo.Date:dd/MM/yyyy}",
                $"{r.Payment?.ToString(CultureInfo.CurrentCulture)}",
                $"{r.Type}"
            };
            return r.ID;
        }
        protected override void initializeDatabase(ApplicationDbContext context)
        {
            AspNetUserInitializer.Initialize(context);
        }
        protected static void addAspNetUser(string id)
        {
            aspNetUser = new ApplicationUser { Id = id };
            db.Users.Add(aspNetUser);
            db.SaveChanges();
            addAccount(id);
        }
        protected static void addAccount(string aspnetId) {
            account = new AccountData {ID = GetRandom.String(), AspNetUserId = aspnetId};
            db.Accounts.Add(account);
            db.SaveChanges();
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
                $"<a class=\"btn btn-default \" href=\"/{controller}?page=2\">",
            };
            strings.AddRange(specificStringsToTestInIndexView());
            await testWhenLoggedIn(a, strings.ToArray());
        }
        [TestMethod]
        public async Task CreateTest()
        {
            await createTest(x => x.Create(aspNetUser.Id), controller, "New account");
        }

        protected async Task createTest(Expression<Func<InsuranceController, object>> action,
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
       
        [TestMethod]
        public async Task CreateAllGivenTest()
        {
            //Assert.Inconclusive();
            await createAllGivenTest<InsuranceController>(createRandomViewModel, x => x.Create(aspNetUser.Id));
        }
    }
}
