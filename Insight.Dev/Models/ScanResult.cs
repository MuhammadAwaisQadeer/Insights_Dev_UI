namespace Insight.Dev.Models
{
    public class ScanResult
    {
        public Guid ScanId { get; set; } = Guid.NewGuid(); // Unique ID for the scan
        public Guid AssetId { get; set; } // Links scan result to a discovered asset
        public string AssetName { get; set; } // Human-readable asset name
        public string IPAddress { get; set; } // IP of the scanned asset
        public string ScanType { get; set; } // Network, Cloud, Compliance
        public DateTime ScanTime { get; set; } = DateTime.UtcNow; // Timestamp of the scan
        public string Result { get; set; } // Pass/Fail
        public string Status { get; set; } // Completed, In Progress, Failed
    }

}
