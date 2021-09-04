using _01.Logger.Enumerators;
using _01.Logger.Layout;

namespace _01.Logger.Appenders
{
    public interface IAppender
    {
        public ILayout Layout { get; }
        public ReportLevel ReportLevel { get; set; }
        public void Append(string dateTime, ReportLevel report, string message);
    }
}
