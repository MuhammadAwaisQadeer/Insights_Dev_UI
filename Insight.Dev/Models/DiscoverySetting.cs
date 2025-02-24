namespace Insight.Dev.Models
{
    public class DiscoverySetting
    {
        public string SettingId { get; set; }  // Unique identifier (DS001, DS002, etc.)
        public string Parameter { get; set; }  // Name of the setting
        public string Value { get; set; }  // Current value (e.g., "10", "300 seconds", "True")
    }
}
