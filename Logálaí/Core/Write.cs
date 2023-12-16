namespace Logalai.Core
{
    internal class Write
    {
        public static void AppendToFile(string message)
        {
            try
            {
                string fileName = $"log_{DateTime.Now:yyyyMMdd_HHmmSS}.txt";
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

                using (StreamWriter streamWriter = new StreamWriter(filePath, true))
                {
                    streamWriter.WriteLine(message);
                }
            }
            catch (Exception ex)
            {
                Log log = new Log();
                log.Error($"Unable to write to file! {ex.Message}");
            }
        }
    }
}
