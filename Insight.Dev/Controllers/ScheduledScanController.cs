using Insight.Dev.Models;
using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class ScheduledScanController : Controller
    {
        private readonly ScheduledScanService _service;

        public ScheduledScanController()
        {
            _service = new ScheduledScanService();
        }

        public IActionResult Index()
        {
            var scheduledScans = _service.GetScans();

            // Ensure the model is never null
            if (scheduledScans == null)
            {
                scheduledScans = new List<ScheduledScan>();
            }

            return View(scheduledScans);
        }
    }
}
