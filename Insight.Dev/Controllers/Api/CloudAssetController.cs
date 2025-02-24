using Insight.Dev.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insight.Dev.Controllers.Api
{
        [Route("api/cloud-assets")]
        [ApiController]
        public class CloudAssetController : ControllerBase
        {
        private static List<CloudAsset> _cloudAssets = new List<CloudAsset>
        { 
            // AWS Instances
            new CloudAsset { AssetId = "CA001", Provider = "AWS", Region = "us-east-1", Type = "EC2 Instance", Status = "Running" },
            new CloudAsset { AssetId = "CA002", Provider = "AWS", Region = "us-west-2", Type = "RDS Database", Status = "Stopped" },
            new CloudAsset { AssetId = "CA003", Provider = "AWS", Region = "eu-central-1", Type = "S3 Bucket", Status = "Active" },

            // Azure Virtual Machines
            new CloudAsset { AssetId = "CA004", Provider = "Azure", Region = "West Europe", Type = "Virtual Machine", Status = "Stopped" },
            new CloudAsset { AssetId = "CA005", Provider = "Azure", Region = "East US", Type = "App Service", Status = "Running" },
            new CloudAsset { AssetId = "CA006", Provider = "Azure", Region = "Southeast Asia", Type = "SQL Database", Status = "Active" },

            // GCP Compute Resources
            new CloudAsset { AssetId = "CA007", Provider = "GCP", Region = "asia-south1", Type = "Compute Instance", Status = "Running" },
            new CloudAsset { AssetId = "CA008", Provider = "GCP", Region = "us-central1", Type = "Kubernetes Cluster", Status = "Pending" },
            new CloudAsset { AssetId = "CA009", Provider = "GCP", Region = "europe-west1", Type = "Cloud Function", Status = "Active" },

            // IBM Cloud & Oracle Cloud (for variety)
            new CloudAsset { AssetId = "CA010", Provider = "IBM Cloud", Region = "dal10", Type = "Bare Metal Server", Status = "Running" },
            new CloudAsset { AssetId = "CA011", Provider = "Oracle Cloud", Region = "us-ashburn-1", Type = "Autonomous Database", Status = "Stopped" },

            // AliCloud (Alibaba Cloud)
            new CloudAsset { AssetId = "CA012", Provider = "Alibaba Cloud", Region = "ap-southeast-1", Type = "ECS Instance", Status = "Running" }
        };


        [HttpGet("getAssets")]
            public IActionResult GetCloudAssets()
            {
                return Ok(_cloudAssets);
            }


        }
}
