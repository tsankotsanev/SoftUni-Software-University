using System;
using System.Linq;
using _01.Logger.Appenders;
using _01.Logger.Logger;

namespace _01.Logger.Engine
{
    public class Engine : IEngine
    {
        private IAppender[] appenders;
        private IAppender appender;
        private ILogger logger;
        public void Run()
        {
            var number = int.Parse(Console.ReadLine());
            appenders = new IAppender[number];
            for (var i = 0; i < number; i++)
            {
                var appendData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                appender = Factories.AppenderFactory.CreateAppender(appendData);
                appenders[i] = appender;
            }
            logger = new Logger.Logger(appenders);
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "END")
            {
                var loggerArgs = input
                    .Split('|', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                PrintReportLevel(loggerArgs);
            }
            foreach (var appender in appenders)
            {
                Console.WriteLine(appender);
            }
        }
        private void PrintReportLevel(string[] args)
        {
            var reportType = args[0];
            var dateTime = args[1];
            var message = args[2];
            switch (reportType)
            {
                case "INFO":
                    logger.Info(dateTime, message);
                    break;
                case "WARNING":
                    logger.Warning(dateTime, message);
                    break;
                case "ERROR":
                    logger.Error(dateTime, message);
                    break;
                case "CRITICAL":
                    logger.Critical(dateTime, message);
                    break;
                case "FATAL":
                    logger.Fatal(dateTime, message);
                    break;
            }
        }
    }
}
