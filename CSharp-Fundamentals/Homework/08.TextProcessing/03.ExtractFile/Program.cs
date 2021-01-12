using System;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Console.ReadLine();

            var startIndexOfFile = path.LastIndexOf('\\') + 1;
            var file = path.Substring(startIndexOfFile);

            var startIndexOfExtension = file.IndexOf('.') + 1;

            var fileName = file.Substring(0, startIndexOfExtension - 1);
            var fileExtension = file.Substring(startIndexOfExtension);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}