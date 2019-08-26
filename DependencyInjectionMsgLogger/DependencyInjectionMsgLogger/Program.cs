using System;

namespace DependencyInjectionMsgLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            string msg = "DataBase ";

            ILogger logger;

            switch (msg)
            {
                case "File":
                    logger = new TextFileLogger();
                    break;

                default:
                    logger = new DatabaseLogger();
                    break;
            }

            LogHelper logHelper = new LogHelper(logger);
            logger.Log(msg);

            Console.ReadLine();
        }
    }

    interface ILogger
    {
        void Log(string message);
    }

    class LogHelper
    {
        private ILogger _ILoger;
        public LogHelper(ILogger iLogger)
        {
            _ILoger = iLogger;
        }

        public void Log(string message)
        {
            _ILoger.Log(message);
        }

    }
    class TextFileLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + "Will be written in the text file");
        }
    }

    class DatabaseLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message + "Will be written in Database");

        }
    }

}
