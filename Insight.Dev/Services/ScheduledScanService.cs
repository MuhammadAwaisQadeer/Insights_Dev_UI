using Insight.Dev.Models;

namespace Insight.Dev.Services
{
    public class ScheduledScanService
    {
        public List<ScheduledScan> GetScans()
        {
            return new List<ScheduledScan>
            {
                new ScheduledScan { Name = "Weekly Network Scan", ScanType = "Network", Frequency = "Weekly", StartTime = new TimeSpan(2, 0, 0), IsActive = true },
                new ScheduledScan { Name = "Monthly Cloud Compliance Scan", ScanType = "Cloud", Frequency = "Monthly", StartTime = new TimeSpan(1, 0, 0), IsActive = true },
                new ScheduledScan { Name = "Daily Agent Log Pull", ScanType = "Agent", Frequency = "Daily", StartTime = new TimeSpan(12, 0, 0), IsActive = false }
            };
        }
    }
}
