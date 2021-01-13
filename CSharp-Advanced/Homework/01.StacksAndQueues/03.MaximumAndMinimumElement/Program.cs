using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaximumAndMinimumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();

            var commandsCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < commandsCount; i++)
            {
                var splitInput = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var command = splitInput[0];

                switch (command)
                {
                    case "1":
                        var elementToAdd = int.Parse(splitInput[1]);

                        numbers.Push(elementToAdd);
                        break;
                    case "2":
                        numbers.Pop();
                        break;
                    case "3":
                        if (numbers.Count != 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        break;
                    case "4":
                        if (numbers.Count != 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
