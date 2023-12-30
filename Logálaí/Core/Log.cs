namespace Logalai.Core
{
    public class Log
    {
        /// <summary>
        /// Log an error to the console.
        /// </summary>
        /// <param name="message">The content of the error.</param>
        public static void Error(string message)
        {
            Log instance = new Log();
            instance.LogMsg(0, message);
        }

        /// <summary>
        /// Log a warning to the console.
        /// </summary>
        /// <param name="message">The content of the warning.</param>
        public static void Warning(string message)
        {
            Log instance = new Log();
            instance.LogMsg(1, message);
        }

        /// <summary>
        /// Log a general message to the console.
        /// </summary>
        /// <param name="message">The content of the message.</param>
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
        }

        public Log()
        {

        }
    }
}
