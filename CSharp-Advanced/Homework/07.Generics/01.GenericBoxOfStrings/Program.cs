using System;

namespace _01.GenericBoxofStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());

            for (var i = 0; i < count; i++)
            {
                var input = Console.ReadLine();
                var box = new Box<string>(input);
                Console.WriteLine(box);
            }
        }
    }
}
