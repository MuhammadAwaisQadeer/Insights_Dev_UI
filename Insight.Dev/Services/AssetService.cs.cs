using Insight.Dev.Models;

namespace Insight.Dev.Services
{
    public class AssetService
    {
        private static readonly List<Asset> Assets = new()
    {
        new Asset { Id = Guid.NewGuid(), Name = "Server-001", IPAddress = "192.168.1.10", OperatingSystem = "Windows Server 2019", Status = "Online", RiskLevel = "Medium", LastSeen = DateTime.UtcNow },
        new Asset { Id = Guid.NewGuid(), Name = "Workstation-002", IPAddress = "192.168.1.20", OperatingSystem = "Ubuntu 20.04", Status = "Offline", RiskLevel = "Low", LastSeen = DateTime.UtcNow.AddHours(-5) },
        new Asset { Id = Guid.NewGuid(), Name = "Database-Server-003", IPAddress = "192.168.1.30", OperatingSystem = "Windows Server 2016", Status = "Online", RiskLevel = "High", LastSeen = DateTime.UtcNow.AddMinutes(-15) },
        new Asset { Id = Guid.NewGuid(), Name = "Linux-Host-004", IPAddress = "192.168.1.40", OperatingSystem = "CentOS 8", Status = "Online", RiskLevel = "Medium", LastSeen = DateTime.UtcNow.AddHours(-1) },
        new Asset { Id = Guid.NewGuid(), Name = "Web-Server-005", IPAddress = "192.168.1.50", OperatingSystem = "Windows Server 2022", Status = "Offline", RiskLevel = "Low", LastSeen = DateTime.UtcNow.AddDays(-1) },
        new Asset { Id = Guid.NewGuid(), Name = "Mac-Device-006", IPAddress = "192.168.1.60", OperatingSystem = "macOS Monterey", Status = "Online", RiskLevel = "Low", LastSeen = DateTime.UtcNow },
        new Asset { Id = Guid.NewGuid(), Name = "Firewall-007", IPAddress = "192.168.1.70", OperatingSystem = "Cisco IOS", Status = "Online", RiskLevel = "High", LastSeen = DateTime.UtcNow.AddMinutes(-30) },
        new Asset { Id = Guid.NewGuid(), Name = "NAS-Storage-008", IPAddress = "192.168.1.80", OperatingSystem = "Synology DSM", Status = "Online", RiskLevel = "Medium", LastSeen = DateTime.UtcNow.AddMinutes(-10) },
        new Asset { Id = Guid.NewGuid(), Name = "Printer-009", IPAddress = "192.168.1.90", OperatingSystem = "Embedded Linux", Status = "Offline", RiskLevel = "Low", LastSeen = DateTime.UtcNow.AddDays(-2) },
        new Asset { Id = Guid.NewGuid(), Name = "Laptop-010", IPAddress = "192.168.1.100", OperatingSystem = "Windows 10", Status = "Online", RiskLevel = "Medium", LastSeen = DateTime.UtcNow.AddHours(-3) },
        new Asset { Id = Guid.NewGuid(), Name = "Workstation-011", IPAddress = "192.168.1.110", OperatingSystem = "Ubuntu 22.04", Status = "Offline", RiskLevel = "High", LastSeen = DateTime.UtcNow.AddDays(-5) },
        new Asset { Id = Guid.NewGuid(), Name = "IoT-Device-012", IPAddress = "192.168.1.120", OperatingSystem = "Raspberry Pi OS", Status = "Online", RiskLevel = "Medium", LastSeen = DateTime.UtcNow.AddMinutes(-5) }
    };

        public List<Asset> GetMockAssets()
        {
            return Assets;
        }
    }
}
