using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class AssetsController : Controller
    {
        private readonly AssetService _assetService;

        public AssetsController()
        {
            _assetService = new AssetService();
        }

        public IActionResult Index()
        {
            var assets = _assetService.GetMockAssets();
            return View(assets);
        }
    }
}
