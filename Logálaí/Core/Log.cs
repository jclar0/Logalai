namespace Logalai.Core
{
    public class Log
    {
        public void Error(string message)
        {
            Console.WriteLine("[ERROR] " + message);
            Write.AppendToFile("[ERROR] " + message);
        }

        public void Warning(string message)
        {
            Console.WriteLine("[WARNING] " + message);
            Write.AppendToFile("[WARNING] " + message);
        }

        public void Info(string message)
        {
            Console.WriteLine("[INFO] " + message);
            Write.AppendToFile("[INFO] " + message);
        }

        public Log()
        {

        }
    }
}
