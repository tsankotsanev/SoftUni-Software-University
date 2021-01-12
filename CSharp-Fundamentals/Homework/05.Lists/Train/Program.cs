using System;
using System.Linq;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagons = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var maximumCapacity = int.Parse(Console.ReadLine());

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                var splitCommand = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                var action = splitCommand[0];

                if (action == "Add")
                {
                    var passengers = int.Parse(splitCommand[1]);

                    wagons.Add(passengers);
                }
                else
                {
                    var passengers = int.Parse(splitCommand[0]);

                    for (var i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= maximumCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
