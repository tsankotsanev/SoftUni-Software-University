using System;
using System.IO;
using System.Linq;

namespace _01.Logger.Logger
{
    public class LogFile : ILogFile
    {
        private const string LogFilePath = "../../../log.txt";
        public int Size { get; set; }

        public void Write(string message)
        {
            File.AppendAllText(LogFilePath, message + Environment.NewLine);
            Size = message.ToCharArray().Where(char.IsLetter).Sum(x => x);
        }
    }
}
