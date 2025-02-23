using Insight.Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers
{
    public class ScanController : Controller
    {
        private static List<ScanResult> _mockScanResults = new List<ScanResult>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("startScan")]
        public IActionResult StartScan([FromBody] ScanRequest request)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var scanResult = new ScanResult
            {
                AssetId = Guid.NewGuid(), // Mock Asset ID
                AssetName = "Mock Asset " + new Random().Next(1, 100),
                IPAddress = request.NetworkRange, // Mocked IP as input range
                ScanType = request.ScanType,
                Result = new Random().Next(0, 2) == 1 ? "Pass" : "Fail",
                Status = "Completed"
            };

            _mockScanResults.Add(scanResult);
            return Ok(scanResult);
        }
    }
}
