using EasyAuthSamples.MultiProviderSite.Models.AuthenticatedFeatures;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyAuthSamples.MultiProviderSite.Controllers
{
    public class AuthenticatedFeaturesController : Controller
    {
        private readonly ILogger<AuthenticatedFeaturesController> _logger;

        public AuthenticatedFeaturesController(ILogger<AuthenticatedFeaturesController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new IndexModel(User.Identity);
            return View(model);
        }
    }
}
