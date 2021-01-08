using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            var water = int.Parse(Console.ReadLine());

            const int capacity = 255;
            var filledCapacity = 0;

            for (var i = 0; i < water; i++)
            {
                var litters = int.Parse(Console.ReadLine());

                if (filledCapacity + litters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    filledCapacity += litters;
                }
            }
            
            Console.WriteLine(filledCapacity);
        }
    }
}
