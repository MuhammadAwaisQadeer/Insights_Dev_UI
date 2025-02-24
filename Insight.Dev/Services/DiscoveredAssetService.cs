using Insight.Dev.Models;

namespace Insight.Dev.Services
{
    public class DiscoveredAssetService
    {
        public List<DiscoveredAsset> GetDiscoveredAssets()
        {
            return new List<DiscoveredAsset>
            {
                new DiscoveredAsset { Id = Guid.NewGuid(), Hostname = "Android.attlocal.net", IPAddress = "172.16.200.70", AssetType = "Unknown", Criticality = "Medium", DiscoveryDate = DateTime.UtcNow, IsClassified = false },
                new DiscoveredAsset { Id = Guid.NewGuid(), Hostname = "OMind.attlocal.net", IPAddress = "172.16.200.200", AssetType = "Unknown", Criticality = "Medium", DiscoveryDate = DateTime.UtcNow, IsClassified = false },
                new DiscoveredAsset { Id = Guid.NewGuid(), Hostname = "Server01.local", IPAddress = "192.168.1.10", AssetType = "Server", Criticality = "High", DiscoveryDate = DateTime.UtcNow, IsClassified = true }
            };
        }
    }
}
