using EasyAuthSamples.SimpleSite.Models;
using EasyAuthSamples.SimpleSite.Models.Home;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EasyAuthSamples.SimpleSite.Controllers
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
            var model=new IndexModel();
            model.UserName = Request.GetServicePrincipalName();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RequestDetails()
        {
            var model = new RequestDetailsModel();
            model.Headers=Request.GetHeaders();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}