using Insight.Dev.Models;
using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers.Api
{
    [Route("api/scan")]
    [ApiController]
    public class ApiScanController : ControllerBase
    {
        private readonly ScanService _scanService;

        public ApiScanController()
        {
            _scanService = new ScanService();
        }

        [HttpGet("getScans")]
        public IActionResult GetScans()
        {
            var scans = _scanService.GetScans();
            return Ok(scans);
        }

        [HttpPost("startScan")]
        public async Task<IActionResult> StartScan([FromBody] Scan request)
        {
            if (string.IsNullOrWhiteSpace(request.ScanName) || string.IsNullOrWhiteSpace(request.NetworkRange))
            {
                return BadRequest("Scan name and network range are required.");
            }

            var scanResult = await _scanService.StartScan(request.ScanName, request.NetworkRange, request.ScanType);
            return Ok(scanResult);
        }
    }
}
