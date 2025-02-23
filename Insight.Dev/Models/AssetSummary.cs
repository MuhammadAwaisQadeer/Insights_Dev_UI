namespace Insight.Dev.Models
{
    public class AssetSummary
    {
        public int TotalAssets { get; set; }
        public int ActiveAssets { get; set; }
        public int InactiveAssets { get; set; }
        public int CriticalAssets { get; set; }
    }
}
