using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new Stack<int>();

            var elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var elementsToAdd = int.Parse(elements[0]);
            var elementsToRemove = int.Parse(elements[1]);
            var elementToLookFor = int.Parse(elements[2]);

            var numbersInput = Console.ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (var i = 0; i < elementsToAdd; i++)
            {
                if (numbersInput != null) numbers.Push(numbersInput[i]);
            }

            for (var i = 0; i < elementsToRemove; i++)
            {
                numbers.Pop();
            }


            if (numbers.Count != 0)
            {
                if (numbers.Contains(elementToLookFor))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.Min());
                }
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
