using Insight.Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class DiscoverySettingsController : Controller
    {
        private static List<DiscoverySetting> _mockDiscoverySettings = new List<DiscoverySetting>
{
    new DiscoverySetting { SettingId = "DS001", Parameter = "Max Concurrent Scans", Value = "10" },
    new DiscoverySetting { SettingId = "DS002", Parameter = "Scan Timeout", Value = "300 seconds" },
    new DiscoverySetting { SettingId = "DS003", Parameter = "Enable Logging", Value = "True" }
};

        // GET: DiscoverySettings
        public IActionResult Index()
        {
            return View(_mockDiscoverySettings);
        }

        // GET: DiscoverySettings/Details/{id}
        public IActionResult Details(string id)
        {
            var setting = _mockDiscoverySettings.FirstOrDefault(s => s.SettingId == id);
            if (setting == null) return NotFound();

            return View(setting);
        }

        // GET: DiscoverySettings/Edit/{id}
        public IActionResult Edit(string id)
        {
            var setting = _mockDiscoverySettings.FirstOrDefault(s => s.SettingId == id);
            if (setting == null) return NotFound();

            return View(setting);
        }

        // POST: DiscoverySettings/Edit
        [HttpPost]
        public IActionResult Edit(DiscoverySetting updatedSetting)
        {
            var setting = _mockDiscoverySettings.FirstOrDefault(s => s.SettingId == updatedSetting.SettingId);
            if (setting == null) return NotFound();

            setting.Value = updatedSetting.Value; // Update value
            return RedirectToAction("Index");
        }

        // GET: DiscoverySettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DiscoverySettings/Create
        [HttpPost]
        public IActionResult Create(DiscoverySetting newSetting)
        {
            if (string.IsNullOrWhiteSpace(newSetting.SettingId) || string.IsNullOrWhiteSpace(newSetting.Parameter) || string.IsNullOrWhiteSpace(newSetting.Value))
            {
                return View(newSetting);
            }

            _mockDiscoverySettings.Add(newSetting);
            return RedirectToAction("Index");
        }
    }
}
