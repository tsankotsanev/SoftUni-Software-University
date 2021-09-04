using _01.Logger.Enumerators;
using _01.Logger.Layout;
using _01.Logger.Logger;

namespace _01.Logger.Appenders
{
    public class FileAppender : Appender
    {
        private ILogFile logFile;
        public FileAppender(ILayout layout, ILogFile logFile)
            : base(layout)
        {
            this.logFile = logFile;
        }

        public override void Append(string dateTime, ReportLevel report, string message)
        {
            if (ReportLevel <= report)
            {

                MessagesAppended++;
                logFile.Write(string.Format(Layout.Format, dateTime, report, message));
            }
        }
        public override string ToString()
        {
            return base.ToString() + $", File size: {logFile.Size}";
        }
    }
}
