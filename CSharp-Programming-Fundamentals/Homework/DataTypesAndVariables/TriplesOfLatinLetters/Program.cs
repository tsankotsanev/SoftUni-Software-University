using System;

namespace TriplesOfLatinLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (var i = 'a'; i < 'a' + number; i++)
            {
                for (var j = 'a'; j < 'a' + number; j++)
                {
                    for (var k = 'a'; k < 'a' + number; k++)
                    {
                        Console.WriteLine($"{i}{j}{k}");
                    }
                }
            }
        }
    }
}
