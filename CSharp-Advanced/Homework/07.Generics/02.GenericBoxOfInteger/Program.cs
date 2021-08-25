using System;

namespace _02.GenericBoxOfInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var input = int.Parse(Console.ReadLine());
                var box = new Box<int>(input);
                Console.WriteLine(box);
            }
        }
    }
}
