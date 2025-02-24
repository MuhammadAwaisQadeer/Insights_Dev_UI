namespace Insight.Dev.Models
{
    public class DiscoveredAsset
    {
        public Guid Id { get; set; }
        public string Hostname { get; set; }
        public string IPAddress { get; set; }
        public string AssetType { get; set; } // e.g., Server, Workstation, IoT, Unknown
        public string Criticality { get; set; } // Low, Medium, High
        public DateTime DiscoveryDate { get; set; } = DateTime.UtcNow;
        public bool IsClassified { get; set; } = false; // Track if it's classified

        public string ClassificationStatus { get; set; } // Approved, Ignored, False Positive
    }
}
