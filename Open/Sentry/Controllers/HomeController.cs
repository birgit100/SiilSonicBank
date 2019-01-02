using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Open.Core;
using Open.Data.Bank;
using Open.Domain.Bank;
using Open.Facade.Bank;
using Open.Sentry.Models;

namespace Open.Sentry.Controllers {
    public class HomeController : Controller {
        private readonly IAccountsRepository accounts;
        private readonly UserManager<ApplicationUser> userManager;

        public HomeController(IAccountsRepository a, UserManager<ApplicationUser> uManager) {
            accounts = a;
            userManager = uManager;
        }
        public async Task<IActionResult> Index() {
            var loggedInUser = await userManager.GetUserAsync(HttpContext.User);
            if (loggedInUser == null) return View();
            var bankAccounts = await accounts.LoadAccountsForUser(loggedInUser.Id);
            var bankAccountsViewsList = new AccountsViewsList(bankAccounts);
            await checkForAccountExpire(bankAccountsViewsList);
            return View(bankAccountsViewsList);

        }
        private async Task checkForAccountExpire(AccountsViewsList bankAccountsViewsList) {
            foreach (var account in bankAccountsViewsList) {
                var daysToExpire = (int)Math.Ceiling(((account.ValidTo ?? DateTime.MaxValue) - DateTime.Now)
                    .TotalDays);
                if (daysToExpire < 0) {
                    account.Status = Status.Inactive.ToString();
                    var acc = await accounts.GetObject(account.ID);
                    acc.Data.Status = account.Status;
                    await accounts.UpdateObject(acc);
                    continue;
                }
                if (daysToExpire < 30 && account.Status == "Active") {
                    account.Status = $"Active (expires in {daysToExpire} days)";
                }
            }
        }
        public IActionResult About() {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact() {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error() {
            return View(new ErrorViewModel {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}