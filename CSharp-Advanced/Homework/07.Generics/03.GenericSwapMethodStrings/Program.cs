using System;
using System.Linq;

namespace _03.GenericSwapMethodStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            var box = new Box<string>();
            for (var i = 0; i < count; i++)
            {
                var input = Console.ReadLine();

                box.Value.Add(input);
            }
            var indexes = Console
                .ReadLine()
                ?.Split()
                .Select(int.Parse)
                .ToArray();

            var a = indexes[0];
            var b = indexes[1];
            box.Swap(a, b);
            Console.WriteLine(box);
        }
    }
}
