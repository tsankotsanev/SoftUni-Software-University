using System;
using System.Linq;

namespace ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                var action = splitCommand[0];

                switch (action)
                {
                    case "Add":
                        var numberToAdd = int.Parse(splitCommand[1]);

                        numbers.Add(numberToAdd);
                        break;
                    case "Insert":
                        var numberToInsert = int.Parse(splitCommand[1]);
                        var index = int.Parse(splitCommand[2]);

                        if (index >= 0 && index < numbers.Count)
                        {
                            numbers.Insert(index, numberToInsert);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Remove":
                        var indexToRemove = int.Parse(splitCommand[1]);

                        if (indexToRemove >= 0 && indexToRemove < numbers.Count)
                        {
                            numbers.RemoveAt(indexToRemove);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        break;
                    case "Shift":
                        var direction = splitCommand[1];

                        if (direction == "left")
                        {
                            var count = int.Parse(splitCommand[2]);

                            for (var i = 0; i < count; i++)
                            {
                                var firstNumber = numbers[0];
                                numbers.Add(firstNumber);
                                numbers.RemoveAt(0);
                            }
                        }
                        else if (direction == "right")
                        {
                            var count = int.Parse(splitCommand[2]);

                            for (var i = 0; i < count; i++)
                            {
                                var lastNumber = numbers[^1];
                                numbers.Insert(0, lastNumber);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
