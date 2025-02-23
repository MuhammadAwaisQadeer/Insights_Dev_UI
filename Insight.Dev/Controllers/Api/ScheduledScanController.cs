using Insight.Dev.Models;
using Insight.Dev.Services;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers.Api
{
    [Route("api/scheduledscan")]
    [ApiController]
    public class ScheduledScanController : ControllerBase
    {
        private static List<ScheduledScan> _mockScans = new ScheduledScanService().GetScans();

        [HttpGet("getAll")]
        public IActionResult GetAllScans()
        {
            return Ok(_mockScans);
        }

        [HttpPost("add")]
        public IActionResult AddScan([FromBody] ScheduledScan scan)
        {
            scan.ScheduleId = "DS" + (_mockScans.Count + 1).ToString("D3");
            _mockScans.Add(scan);
            return Ok(scan);
        }

        [HttpDelete("delete/{id}")]
        public IActionResult DeleteScan(string id)
        {
            _mockScans.RemoveAll(s => s.ScheduleId == id);
            return Ok();
        }
    }
}
