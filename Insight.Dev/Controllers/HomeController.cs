using System.Diagnostics;
using Insight.Dev.Models;
using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeService _homeService;

        public HomeController(ILogger<HomeController> logger, HomeService homeService)
        {
            _logger = logger;
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            var dashboardData = new
            {
                Summary = _homeService.GetAssetSummary(),
                ScanProgress = _homeService.GetScanProgress(),
                Alerts = _homeService.GetAlerts(),
                RecentActivities = _homeService.GetRecentActivities()
            };

            return View(dashboardData);
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
