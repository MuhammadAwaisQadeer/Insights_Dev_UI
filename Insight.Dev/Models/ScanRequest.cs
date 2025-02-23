using System.ComponentModel.DataAnnotations;

namespace Insight.Dev.Models
{
    public class ScanRequest
    {
        [Required]
        public string ScanName { get; set; }

        [Required]
        public string NetworkRange { get; set; }

        [Required]
        public string ScanType { get; set; } // "Quick Scan", "Full Scan", etc.
    }
}
