using System;
using System.IO;

namespace _02.LineNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            using var reader = new StreamReader("../../../Input.txt");
            using var writer = new StreamWriter("../../../output.txt");

            var counter = 1;
            var line = reader.ReadLine();

            while (line != null)
            {
                writer.WriteLine($"{counter}. {line}");
                Console.WriteLine($"{counter}. {line}");
                line = reader.ReadLine();
                counter++;
            }
        }
    }
}