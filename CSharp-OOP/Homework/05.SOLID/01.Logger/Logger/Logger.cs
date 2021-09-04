using _01.Logger.Appenders;
using _01.Logger.Enumerators;

namespace _01.Logger.Logger
{
    public class Logger : ILogger
    {
        public Logger(params IAppender[] appender)
        {
            Appenders = appender;
        }

        public IAppender[] Appenders { get; }


        public void Critical(string dateTime, string fileAppender)
        {
            Append(dateTime, ReportLevel.Critical, fileAppender);
        }

        public void Error(string dateTime, string fileAppender)
        {
            Append(dateTime, ReportLevel.Error, fileAppender);
        }

        public void Fatal(string dateTime, string fileAppender)
        {
            Append(dateTime, ReportLevel.Fatal, fileAppender);
        }

        public void Info(string dateTime, string fileAppender)
        {
            Append(dateTime, ReportLevel.Info, fileAppender);
        }

        public void Warning(string dateTime, string fileAppender)
        {
            Append(dateTime, ReportLevel.Warning, fileAppender);
        }
        private void Append(string dateTime, ReportLevel reportLevel, string fileAppender)
        {
            foreach (var appender in Appenders)
            {
                appender.Append(dateTime, reportLevel, fileAppender);
            }
        }
    }
}
