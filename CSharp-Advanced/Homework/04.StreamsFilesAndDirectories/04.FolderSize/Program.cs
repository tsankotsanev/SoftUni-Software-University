using System;
using System.IO;

namespace _04.FolderSize
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = 0.0;
            var directoryPath = Console.ReadLine();
            var files = Directory.GetFiles(directoryPath);

            foreach (var file in files)
            {
                var infoForFile = new FileInfo(file);
                Console.WriteLine($"{infoForFile.FullName} --> {infoForFile.Length} bytes");
                size += infoForFile.Length;
            }

            Console.WriteLine(size);
        }
    }
}