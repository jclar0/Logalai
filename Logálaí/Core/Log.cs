namespace Logalai.Core
{
    public class Log
    {
        Write write = new Write();

        public static void Error(string message)
        {
            Log instance = new Log();
            instance.LogMsg(0, message);
        }

        public static void Warning(string message)
        {
            Log instance = new Log();
            instance.LogMsg(1, message);
        }

        public static void Info(string message)
        {
            Log instance = new Log();
            instance.LogMsg(2, message);
        }

        private void LogMsg(int level, string message)
        {
            string typeToLog;

            switch (level)
            {
                case 0:
                    typeToLog = "[ERROR]";
                    break;
                case 1:
                    typeToLog = "[WARNING]";
                    break;
                case 2:
                    typeToLog = "[INFO]";
                    break;
                default:
                    typeToLog = "[UNKNOWN]";
                    break;
            }

            string toLog = $"{DateTime.Now} {typeToLog} {message}";

            Console.WriteLine(toLog);
            write.AppendToFile(toLog);
        }

        public Log()
        {

        }
    }
}
