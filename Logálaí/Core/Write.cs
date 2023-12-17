namespace Logalai.Core
{
    internal class Write
    {
        public void AppendToFile(string message)
        {
            try
            {
                string fileName = $"log_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
                string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

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
