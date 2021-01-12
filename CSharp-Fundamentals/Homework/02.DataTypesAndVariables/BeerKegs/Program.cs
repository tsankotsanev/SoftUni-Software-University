using System;

namespace BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            var kegsCount = int.Parse(Console.ReadLine());

            var biggestKeg = double.MinValue;
            var biggestKegName = string.Empty;

            for (var keg = 0; keg < kegsCount; keg++)
            {
                var model = Console.ReadLine();
                var radius = double.Parse(Console.ReadLine());
                var height = int.Parse(Console.ReadLine());

                var volume = Math.PI * (radius * radius) * height;

                if (volume > biggestKeg)
                {
                    biggestKegName = model;
                    biggestKeg = volume;
                }
            }

            Console.WriteLine(biggestKegName);
        }
    }
}
