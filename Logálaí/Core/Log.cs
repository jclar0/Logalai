namespace Logalai.Core
{
    public class Log
    {
        public void Error(string message)
        {
            Console.WriteLine($"{DateTime.Now} [ERROR] " + message);
            Write.AppendToFile($"{DateTime.Now} [ERROR] " + message);
        }

        public void Warning(string message)
        {
            Console.WriteLine($"{DateTime.Now} [WARNING] " + message);
            Write.AppendToFile($"{DateTime.Now} [WARNING] " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine($"{DateTime.Now} [INFO] " + message);
            Write.AppendToFile($"{DateTime.Now} [INFO] " + message);
        }

        public Log()
        {

        }
    }
}
