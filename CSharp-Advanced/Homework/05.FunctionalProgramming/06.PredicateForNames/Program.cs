using System;
using System.Linq;

namespace _06.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var names = Console
                .ReadLine()
                ?.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Func<string[], int, string[]> namesLength = (name, num) =>
            {
                foreach (var person in name)
                {
                    if (person.Length <= num)
                    {
                        Console.WriteLine(person);
                    }

                }
                return name;
            };

            namesLength(names, num);
        }
    }
}