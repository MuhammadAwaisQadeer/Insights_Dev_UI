using Insight.Dev.Models;

namespace Insight.Dev.Services
{
    public class ScanService
    {
        private static List<Scan> _scans = new List<Scan>();

        public List<Scan> GetScans()
        {
            return _scans.OrderByDescending(s => s.LastRun).ToList();
        }

        //public async Task<Scan> StartScan(string scanName, string networkRange, string scanType)
        //{
        //    var scan = new Scan
        //    {
        //        Id = _scans.Count + 1,
        //        ScanName = scanName,
        //        NetworkRange = networkRange,
        //        ScanType = scanType,
        //        Status = "Scanning...",
        //        LastRun = DateTime.UtcNow
        //    };

        //    _scans.Add(scan);

        //    // Simulate scan processing time (5 seconds)
        //    await Task.Delay(5000);

        //    // Randomly determine if scan is "Completed" or "Failed"
        //    scan.Status = new Random().Next(0, 100) > 20 ? "Completed" : "Failed";
        //    return scan;
        //}

        public async Task<Scan> StartScan(string scanName, string networkRange, string scanType)
        {
            var scan = new Scan
            {
                Id = _scans.Count + 1,
                ScanName = scanName,
                NetworkRange = networkRange,
                ScanType = scanType,
                Status = "Scanning", // Ensure Status is always set
                LastRun = DateTime.UtcNow
            };

            await Task.Delay(5000); // Simulating scan process

            scan.Status = new Random().Next(0, 100) > 20 ? "Completed" : "Failed"; // Randomize success/failure

            return scan;
        }


    }
}
