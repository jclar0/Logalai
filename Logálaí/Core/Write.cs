namespace Logalai.Core
{
    internal class Write
    {
        public void AppendToFile(string message)
        {
            try
            {
                int maxLogs = 5; // The maximum number of log files that can be created
                string dirPath = Environment.CurrentDirectory;
                string fileName = $"log_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                // Get all the existing log files, store them in an array
                string[] logFiles = Directory.GetFiles(dirPath, "log_*.txt");

                if (logFiles.Length >= maxLogs)
                {
                    // Delete the older logs first
                    // (This is messy, and I don't even understand it all too well,
                    // but hopefully it just WORKS. I pray for it.)
                    var fsToDelete = logFiles.Select(f => new FileInfo(f))
                        .OrderBy(f => f.CreationTime).Take(logFiles.Length - maxLogs + 1).ToList();

                    foreach (var fToDelete in fsToDelete)
                    {
                        File.Delete(fToDelete.FullName);
                    }
                }

                string logName = string.Format(fileName, DateTime.Now);
                string filePath = Path.Combine(dirPath, logName);

                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unable to write to file! {ex.Message}");
            }
        }
    }
}
