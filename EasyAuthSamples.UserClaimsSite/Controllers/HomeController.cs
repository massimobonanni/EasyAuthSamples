using EasyAuthSamples.UserClaimsSite.Models;
using EasyAuthSamples.UserClaimsSite.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EasyAuthSamples.Common.Extensions;

namespace EasyAuthSamples.UserClaimsSite.Controllers
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
            var model = new IndexModel(User.Identity);
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RequestDetails()
        {
            var model = new RequestDetailsModel();
            model.Headers = Request.GetHeaders();
            model.UserClaims = this.User.GetClaims();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}