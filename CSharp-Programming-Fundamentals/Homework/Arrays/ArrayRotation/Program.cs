using System;
using System.Linq;

namespace ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine()
                .Split()
                .ToArray();

            var number = int.Parse(Console.ReadLine());

            for (var i = 0; i < number; i++)
            {
                var firstElement = array[0];

                for (var j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }

                array[^1] = firstElement;
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
