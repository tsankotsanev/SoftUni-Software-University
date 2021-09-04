using _01.Logger.Enumerators;
using _01.Logger.Layout;

namespace _01.Logger.Appenders
{
    public abstract class Appender : IAppender
    {
        protected Appender(ILayout layout)
        {
            Layout = layout;
        }
        public ILayout Layout { get; }

        public ReportLevel ReportLevel { get; set; }
        protected int MessagesAppended { get; set; }

        public abstract void Append(string dateTime, ReportLevel report, string message);
        public override string ToString()
        {
            return $"Appender type: {GetType().Name}, Layout type: {Layout}, Report level: {ReportLevel.ToString().ToUpper()}, Messages appended: {MessagesAppended}";
        }
    }
}