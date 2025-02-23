using Insight.Dev.Models;

namespace Insight.Dev.Services
{
    public class HomeService
    {
        public AssetSummary GetAssetSummary()
        {
            return new AssetSummary
            {
                TotalAssets = 120,
                ActiveAssets = 95,
                InactiveAssets = 25,
                CriticalAssets = 8
            };
        }

        public ScanProgress GetScanProgress()
        {
            return new ScanProgress
            {
                TotalAssetsToScan = 50,
                ScannedAssets = 12,
                Status = "In Progress"
            };
        }

        public List<Alert> GetAlerts()
        {
            return new List<Alert>
        {
            new Alert { Message = "Critical asset detected: Server-001", Severity = "Critical", Timestamp = DateTime.UtcNow.AddMinutes(-10) },
            new Alert { Message = "Warning: Unauthorized access attempt on Workstation-002", Severity = "Warning", Timestamp = DateTime.UtcNow.AddMinutes(-30) },
            new Alert { Message = "System scan completed successfully", Severity = "Info", Timestamp = DateTime.UtcNow.AddHours(-1) }
        };
        }

        public List<RecentActivity> GetRecentActivities()
        {
            return new List<RecentActivity>
        {
            new RecentActivity { Description = "Asset Server-001 was added.", Timestamp = DateTime.UtcNow.AddMinutes(-15) },
            new RecentActivity { Description = "Asset Laptop-010 went offline.", Timestamp = DateTime.UtcNow.AddMinutes(-45) },
            new RecentActivity { Description = "Rescan initiated for Database-Server-003.", Timestamp = DateTime.UtcNow.AddMinutes(-60) }
        };
        }
    }
}
