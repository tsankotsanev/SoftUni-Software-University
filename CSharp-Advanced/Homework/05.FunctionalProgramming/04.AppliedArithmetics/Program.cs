using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var command = string.Empty;

            Action<int[]> print = num => Console.WriteLine(string.Join(" ", numbers));

            Func<int[], string, int[]> manipulator = (numbers, command) =>
            {
                return command switch
                {
                    "add" => numbers.Select(x => x + 1).ToArray(),
                    "multiply" => numbers.Select(x => x * 2).ToArray(),
                    "subtract" => numbers.Select(x => x - 1).ToArray(),
                    _ => numbers.Select(x => x).ToArray()
                };
            };

            while ((command = Console.ReadLine()) != "end")
            {
                if (command == "print")
                {
                    print(numbers);
                    continue;
                }

                numbers = manipulator(numbers, command);
            }
        }
    }
}