using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Commands
{
    class Program
    {
        static void Main(string[] args)
        {
            var collection = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var commandArgs = input.Split(" ");
                var command = commandArgs[0];

                if (command == "reverse")
                {
                    var start = int.Parse(commandArgs[2]);
                    var count = int.Parse(commandArgs[4]);

                    collection.Reverse(start, count);
                }
                else if (command == "sort")
                {
                    var start = int.Parse(commandArgs[2]);
                    var count = int.Parse(commandArgs[4]);

                    collection.Sort(start, count, Comparer<int>.Default);
                }
                else if (command == "remove")
                {
                    var range = int.Parse(commandArgs[1]);

                    collection.RemoveRange(0, range);
                }
            }

            var convertedCollection = collection
                .ConvertAll(e => e.ToString());

            Console.WriteLine(string.Join(", ", convertedCollection));
        }
    }
}
