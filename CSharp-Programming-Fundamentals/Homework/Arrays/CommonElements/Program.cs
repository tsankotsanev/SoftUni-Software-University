using System;
using System.Linq;

namespace CommonElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstArray = Console.ReadLine()
                .Split(" ")
                .ToArray();

            var secondArray = Console.ReadLine()
                .Split(" ")
                .ToArray();

            foreach (var secondItem in secondArray)
            {
                foreach (var firstItem in firstArray)
                {
                    if (secondItem == firstItem)
                    {
                        Console.Write(secondItem + " ");
                    }
                }
            }
        }
    }
}
