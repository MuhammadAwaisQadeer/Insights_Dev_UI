namespace Insight.Dev.Models
{
    public class AuthenticationResult
    {
        public Guid AssetId { get; set; }
        public string Protocol { get; set; } // SSH, SMB, LDAP, SNMP
        public string Status { get; set; } // Success / Failure
        public DateTime AttemptTime { get; set; }
    }

}
