using System;
using _01.Logger.Enumerators;
using _01.Logger.Layout;

namespace _01.Logger.Appenders
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout)
              : base(layout)
        {
        }

        public override void Append(string dateTime, ReportLevel report, string message)
        {
            if (ReportLevel <= report)
            {
                MessagesAppended++;
                Console.WriteLine(Layout.Format, dateTime, report, message);
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
