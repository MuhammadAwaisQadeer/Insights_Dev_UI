using Insight.Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class CloudAssetController : Controller
    {
        private static List<CloudAsset> _cloudAssets = new List<CloudAsset>();

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Details(string id)
        {
            var asset = _cloudAssets.FirstOrDefault(a => a.AssetId == id);
            if (asset == null)
                return NotFound();

            return View(asset);
        }
    }
}
