using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Open.Aids;
using Open.Domain.Party;
using Open.Infra;
using Open.Sentry.Controllers;
using Open.Sentry.Models.AccountViewModels;
namespace Open.Tests.Sentry.Controllers
{
    [TestClass]
    public class AccountControllerTests : AcceptanceTests<ApplicationDbContext>
    {
        private ApplicationDbContext appDbContext;
        private RegisterViewModel currentUser;
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            type = typeof(AccountController);
            var scope = server.Host.Services.CreateScope();
            var services = scope.ServiceProvider;
            appDbContext = services.GetService<ApplicationDbContext>();
        }
        [TestMethod]
        public async Task LoginTest()
        {
            var a = GetUrl.ForControllerAction<AccountController>(x => x.Login(null));
            await testControllerAction(a,
                "<h2>Log in</h2>",
                "<form method=\"post\" action=\"/Account/Login\">",
                "<h4>Use a local account to log in</h4>",
                "<label for=\"Email\">Email</label>",
                "<label for=\"Password\">Password</label>",
                "<label for=\"RememberMe\">",
                "<button type=\"submit\" class=\"btn btn-primary btn-block\">Log in</button>",
                "<a href=\"/Account/ForgotPassword\">Forgot your password?</a>",
                "<a href=\"/Account/Register\">Register as a new user?</a>"
            );
        }
        [TestMethod]
        public async Task LoginPostTest()
        {
            Task validate(object o) => Task.CompletedTask;
            IEnumerable<KeyValuePair<string, string>> createContext(object o)
            {
                var x = o as LoginViewModel;
                var d = new Dictionary<string, string> {
                    {GetMember.Name<LoginViewModel>(m => m.Email), x?.Email},
                    {GetMember.Name<LoginViewModel>(m => m.Password), x?.Password},
                    {GetMember.Name<LoginViewModel>(m => m.RememberMe), x?.RememberMe.ToString()}
                };
                return d;
            }
            object createObject()
            {
                var vm = GetRandom.Object<LoginViewModel>();
                vm.Email = currentUser.Email;
                vm.Password = currentUser.Password;
                return vm;
            }
            await RegisterPostTest();
            await createAllGivenTest<AccountController>(x => x.Login(null),
                createObject, createContext, validate);
        }
        [TestMethod]
        public void LoginWith2FaTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void LoginWithRecoveryCodeTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void LockoutTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public async Task RegisterTest()
        {
            var a = GetUrl.ForControllerAction<AccountController>(x => x.Register(null));
            await testControllerAction(a,
                "<h2>Register</h2>",
                "<form method=\"post\" action=\"/Account/Register\">",
                "<h4>Create a new account</h4>",
                "<label for=\"Email\">Email</label>",
                "<label for=\"Password\">Password</label>",
                "<label for=\"ConfirmPassword\">Confirm password</label>",
                "<button style=\"margin-top: 48px\" type=\"submit\" class=\"btn btn-primary btn-block\">Register</button>"
            );
        }
        [TestMethod]
        public async Task RegisterPostTest()
        {
            Assert.Inconclusive();
            async Task validate(object o)
            {
                var vm = o as RegisterViewModel;
                Assert.IsNotNull(vm);
                var y = await appDbContext.Users.FirstOrDefaultAsync(x =>
                    x.Email == vm.Email);
                Assert.AreEqual(y.Email, vm.Email);
                currentUser = vm;
            }
            IEnumerable<KeyValuePair<string, string>> createContext(object o)
            {
                var x = o as RegisterViewModel;
                var d = new Dictionary<string, string> {
                    {GetMember.Name<RegisterViewModel>(m => m.FirstName), x?.FirstName},
                    {GetMember.Name<RegisterViewModel>(m => m.LastName), x?.LastName},
                    {GetMember.Name<RegisterViewModel>(m => m.DateOfBirth.ToString()), x?.DateOfBirth.ToString()},
                    {GetMember.Name<RegisterViewModel>(m => m.Email), x?.Email},
                    {GetMember.Name<RegisterViewModel>(m => m.Password), x?.Password},
                    {GetMember.Name<RegisterViewModel>(m => m.ConfirmPassword), x?.ConfirmPassword},
                    {GetMember.Name<RegisterViewModel>(m => m.Country), x?.Country},
                    {GetMember.Name<RegisterViewModel>(m => m.AddressLine), x?.AddressLine},
                    {GetMember.Name<RegisterViewModel>(m => m.ZipCode), x?.ZipCode},
                    {GetMember.Name<RegisterViewModel>(m => m.City), x?.City},
                    {GetMember.Name<RegisterViewModel>(m => m.County), x?.County}
                };
                return d;
            }
            object createObject()
            {
                var vm = GetRandom.Object<RegisterViewModel>();
                vm.Email = GetRandom.Email();
                vm.Password = GetRandom.Password();
                vm.ConfirmPassword = vm.Password;
                vm.FirstName = GetRandom.String();
                vm.LastName = GetRandom.String();
                vm.DateOfBirth = GetRandom.DateTime();
                vm.Country = GetRandom.Object<Country>().ToString();
                vm.AddressLine = GetRandom.String();
                vm.ZipCode = GetRandom.String();
                vm.City = GetRandom.String();
                vm.County = GetRandom.String();
                return vm;
            }
            await createAllGivenTest<AccountController>(x => x.Register(null),
                createObject, createContext, validate);
        }
        [TestMethod]
        public void LogoutTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ExternalLoginTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ExternalLoginCallbackTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ExternalLoginConfirmationTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ConfirmEmailTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ForgotPasswordTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ForgotPasswordConfirmationTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ResetPasswordTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ResetPasswordConfirmationTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void AccessDeniedTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        [TestMethod]
        public void ErrorMessageTest()
        {
            //TODO: Assert.Inconclusive("Don't know how to test");
        }
        protected async Task createAllGivenTest<T>(
            Expression<Func<T, object>> action,
            Func<object> createRandom,
            Func<object, IEnumerable<KeyValuePair<string, string>>> createHttpPostContext,
            Func<object, Task> validateEntityInRepository,
            bool login = false
        ) where T : Controller
        {
            var o = createRandom();
            var a = GetUrl.ForControllerAction(action);
            AuthenticationHandlerTest.IsLoggedIn = true;
            var response = await client.GetAsync(a);
            response.EnsureSuccessStatusCode();
            var d = createHttpPostContext(o);
            var content = new FormUrlEncodedContent(d);
            AuthenticationHandlerTest.IsLoggedIn = login;
            response = await client.PostAsync(a, content);
            Assert.AreEqual(HttpStatusCode.Redirect, response.StatusCode);
            await validateEntityInRepository(o);
        }
        protected override void initializeDatabase(ApplicationDbContext context) {
            AspNetUserInitializer.Initialize(context);
        }
    }
}
