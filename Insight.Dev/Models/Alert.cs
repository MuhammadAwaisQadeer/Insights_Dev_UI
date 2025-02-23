namespace Insight.Dev.Models
{
    public class Alert
    {
        public string Message { get; set; }
        public string Severity { get; set; } // "Critical", "Warning", "Info"
        public DateTime Timestamp { get; set; }
    }

}
