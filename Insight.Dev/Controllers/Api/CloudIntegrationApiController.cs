using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Insight.Dev.Controllers.Api
{
    [Route("api/cloud")]
    [ApiController]
    public class CloudIntegrationApiController : ControllerBase
    {
        private static List<string> ConnectedAccounts = new List<string>
        {
            "Azure - Subscription A",
            "AWS - Account B"
        };

        [HttpGet("getConnectedAccounts")]
        public IActionResult GetConnectedAccounts()
        {
            return Ok(ConnectedAccounts);
        }

        [HttpPost("connect")]
        public IActionResult ConnectCloud([FromBody] CloudAccount account)
        {
            if (string.IsNullOrWhiteSpace(account.Provider))
                return BadRequest("Cloud provider is required.");

            string newAccount = $"{account.Provider.ToUpper()} - {account.SubscriptionId ?? account.ProjectId ?? "New Account"}";
            ConnectedAccounts.Add(newAccount);
            return Ok(new { message = $"{account.Provider.ToUpper()} Account Connected", account = newAccount });
        }

        [HttpPost("disconnect")]
        public IActionResult DisconnectCloud([FromBody] CloudAccount account)
        {
            ConnectedAccounts.RemoveAll(a => a.Contains(account.SubscriptionId ?? account.ProjectId));
            return Ok(new { message = "Cloud Account Disconnected", account = account.SubscriptionId });
        }
    }

    public class CloudAccount
    {
        public string Provider { get; set; }
        public string SubscriptionId { get; set; }
        public string AccessKey { get; set; }
        public string SecretKey { get; set; }
        public string Region { get; set; }
        public string ProjectId { get; set; }
        public string ServiceKey { get; set; }
    }
}
