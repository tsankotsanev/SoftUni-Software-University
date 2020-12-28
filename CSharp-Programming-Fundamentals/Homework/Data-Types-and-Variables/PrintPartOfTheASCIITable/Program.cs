using System;

namespace PrintPartOfTheASCIITable
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstIndex = int.Parse(Console.ReadLine());
            var secondIndex = int.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
