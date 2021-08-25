using System;
using System.Linq;

namespace _05.ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console
                .ReadLine()
                ?.Split()
                .Select(int.Parse)
                .Reverse()
                .ToArray();

            var num = int.Parse(Console.ReadLine());

            Predicate<int> remove = n => n % num == 0;

            foreach (var number in numbers)
            {
                if (!remove(number))
                {
                    Console.Write($"{number} ");
                }
            }
        }
    }
}