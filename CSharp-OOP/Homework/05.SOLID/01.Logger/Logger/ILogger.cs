
using _01.Logger.Appenders;

namespace _01.Logger.Logger
{
    public interface ILogger
    {
        public IAppender[] Appenders { get; }

        public void Info(string dateTime, string fileAppender);

        public void Warning(string dateTime, string fileAppender);

        public void Error(string dateTime, string fileAppender);

        public void Critical(string dateTime, string fileAppender);

        public void Fatal(string dateTime, string fileAppender);
    }
}
