using System;
using System.Linq;

namespace _04.GenericSwapMethodInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var box = new Box<int>();
            var count = int.Parse(Console.ReadLine());
            for (var i = 0; i < count; i++)
            {
                var num = int.Parse(Console.ReadLine());

                box.Values.Add(num);
            }

            var indexes = Console
                          .ReadLine()
                          .Split()
                          .Select(int.Parse)
                          .ToArray();

            box.Swap(indexes[0], indexes[1]);
            Console.WriteLine(box);
        }
    }
}
