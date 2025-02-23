namespace Insight.Dev.Models
{
    public class Asset
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string IPAddress { get; set; }
        public string OperatingSystem { get; set; }
        public string Status { get; set; } // Online / Offline
        public string RiskLevel { get; set; } // Low, Medium, High
        public DateTime LastSeen { get; set; }
    }

}
