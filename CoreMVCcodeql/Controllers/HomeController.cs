using CoreMVCcodeql.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace CoreMVCcodeql.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public string UpdateCustomerPassword(string txtUsername, string txtPassword)
        {
            string userName = txtUsername;
            string password = txtPassword;

            Regex testPassword = new Regex(userName);
            Match match = testPassword.Match(password);
            if (match.Success)
            {
                return "Do not include name in password.";
            }
            else
            {
                return "Good password.";
            }
        }
    }
}
