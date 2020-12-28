using System;

namespace CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = char.Parse(Console.ReadLine());
            var end = char.Parse(Console.ReadLine());

            PrintCharactersInRangeAsASCII(start,end);
        }

        private static void PrintCharactersInRangeAsASCII(char start, char end)
        {
            for (var i = Math.Min(start, end) + 1; i < Math.Max(start, end); i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
