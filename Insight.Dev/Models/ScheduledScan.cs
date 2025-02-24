using System.ComponentModel.DataAnnotations;

namespace Insight.Dev.Models
{
    public class ScheduledScan
    {
        [Key]
        public Guid Id { get; set; }
        public string ScheduleId { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();
        public string Name { get; set; }
        public string ScanType { get; set; } // Network, Cloud, Agent
        public string Frequency { get; set; } // Daily, Weekly, Monthly
        public TimeSpan StartTime { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
