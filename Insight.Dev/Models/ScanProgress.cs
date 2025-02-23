namespace Insight.Dev.Models
{
    public class ScanProgress
    {
        public int TotalAssetsToScan { get; set; }
        public int ScannedAssets { get; set; }
        public string Status { get; set; } // "In Progress", "Completed"
    }
}
