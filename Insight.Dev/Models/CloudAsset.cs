namespace Insight.Dev.Models
{
    public class CloudAsset
    {
        public string AssetId { get; set; }
        public string Provider { get; set; } // AWS, Azure, GCP
        public string Region { get; set; } // e.g., us-east-1, West Europe, asia-south1
        public string Type { get; set; } // EC2 Instance, Virtual Machine, Compute Instance
        public string Status { get; set; } // Running, Stopped, Pending
        public int Storage { get; set; } // Storage in GB
        public int CPU { get; set; } // Number of vCPUs
        public int RAM { get; set; } // RAM in GB
        public string SecurityGroup { get; set; } // Security group name
    }
}
