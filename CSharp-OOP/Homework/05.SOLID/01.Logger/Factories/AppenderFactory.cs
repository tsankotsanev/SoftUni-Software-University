using System;
using _01.Logger.Appenders;
using _01.Logger.Enumerators;
using _01.Logger.Layout;
using _01.Logger.Logger;

namespace _01.Logger.Factories
{
    public class AppenderFactory
    {
        public static IAppender CreateAppender(string[] args)
        {
            IAppender appender = null;
            ILayout layout = layout = LayoutFactory.CreateLayout(args[1]);
            var type = args[0];
            ReportLevel reportLevel;

            if (args.Length == 2)
            {
                reportLevel = ReportLevel.Info;
            }
            else
            {
                Enum.TryParse<ReportLevel>(args[2], out reportLevel);
            }
            switch (type)
            {
                case "ConsoleAppender":
                    appender = new ConsoleAppender(layout);
                    appender.ReportLevel = reportLevel;
                    break;
                case "FileAppender":
                {
                    ILogFile file = new LogFile();
                    appender = new FileAppender(layout, file);
                    appender.ReportLevel = reportLevel;
                    break;
                }
            }

            return appender;
        }
    }
}
