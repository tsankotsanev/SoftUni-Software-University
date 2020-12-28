using System;

namespace SumOfChars
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfLines = int.Parse(Console.ReadLine());
            var sum = 0;
            
            for (var i = 0; i < numberOfLines; i++)
            {
                var letter = char.Parse(Console.ReadLine());
                sum += letter;
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}