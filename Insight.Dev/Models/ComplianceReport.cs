namespace Insight.Dev.Models
{
    public class ComplianceReport
    {
        public string ReportId { get; set; }
        public string ComplianceType { get; set; } // PCI-DSS, HIPAA, NDPR
        public string Status { get; set; } // Compliant / Non-Compliant
        public DateTime GeneratedOn { get; set; }
    }

}
