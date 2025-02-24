
using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class DiscoveredAssetController : Controller
    {

        private readonly DiscoveredAssetService _discoveredAssetService;

        public DiscoveredAssetController()
        {
            _discoveredAssetService = new DiscoveredAssetService();
        }

        public IActionResult Index()
        {
            var discoveredAssets = _discoveredAssetService.GetDiscoveredAssets();
            return View(discoveredAssets);  // Make sure this is returning a valid list
        }

    }
}
