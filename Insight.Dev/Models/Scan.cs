using System.ComponentModel.DataAnnotations;

namespace Insight.Dev.Models
{
        public class Scan
        {
            public int Id { get; set; }

            [Required]
            public string ScanName { get; set; }

            [Required]
            public string NetworkRange { get; set; }

            [Required]
            public string ScanType { get; set; }

            [Required]
            public string Status { get; set; } = "Pending"; // Set a default value

            public DateTime LastRun { get; set; } = DateTime.UtcNow;
        }
}
