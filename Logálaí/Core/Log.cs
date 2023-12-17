namespace Logalai.Core
{
    public class Log
    {
        public void Error(string message)
        {
            LogMsg(0, message);
        }

        public void Warning(string message)
        {
            LogMsg(1, message);
        }

        public void Info(string message)
        {
            LogMsg(2, message);
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

            Console.WriteLine(toLog;
            Write.AppendToFile(toLog);
        }

        public Log()
        {

        }
    }
}
