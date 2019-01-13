using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Core;
using Open.Data.Common;
using Open.Sentry.Controllers;
namespace Open.Tests.Sentry
{
    public abstract class ControllerTests<TContext, TController, TObject, TRecord> : AcceptanceTests<TContext>
        where TContext : DbContext
        where TRecord : IdentifiedData, new()
        where TController : Controller
    {
        protected IRepository<TObject, TRecord> repository { get; set; }
        protected string controller { get; set; }
        protected string actualEditAction { get; set; } = "Edit";
        protected string detailsViewCaption { get; set; }
        protected string editViewCaption { get; set; }
        protected List<string> specificStringsToTestInView { get; set; }
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(TController);
            generateRandomDbRecords();
        }
        private void generateRandomDbRecords()
        {
            for (var i = 0; i < GetRandom.UInt8(15, 20); i++)
                createDbRecord();
        }
        protected virtual string createDbRecord() => string.Empty;

        protected async Task createAllGivenTest<T>(Func<object> createRandom, Expression<Func<T, object>> action)
            where T : Controller
        {
            var o = createRandom();
            var a = GetUrl.ForControllerAction(action);
            AuthenticationHandlerTest.IsLoggedIn = true;
            var response = await client.GetAsync(a);
            response.EnsureSuccessStatusCode();
            var d = createHttpPostContext(o);
            var content = new FormUrlEncodedContent(d);
            AuthenticationHandlerTest.IsLoggedIn = true;
            response = await client.PostAsync(a, content);
            Assert.AreEqual(HttpStatusCode.Redirect, response.StatusCode);
            await validateEntityInRepository(o);
        }

        protected abstract Task validateEntityInRepository(object o);
        protected abstract IEnumerable<KeyValuePair<string, string>> createHttpPostContext(object o);
        protected abstract object createRandomViewModel();
    }
}
