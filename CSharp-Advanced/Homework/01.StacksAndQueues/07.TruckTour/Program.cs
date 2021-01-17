using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            var pumpsData = new Queue<string>();
            var pumpsCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < pumpsCount; i++)
            {
                pumpsData.Enqueue(Console.ReadLine());
            }

            for (var i = 0; i < pumpsCount; i++)
            {
                var currentPetrolAmount = 0;
                var isSuccessful = true;

                for (var j = 0; j < pumpsCount; j++)
                {
                    var pumpDataString = pumpsData.Dequeue();
                    var pumpData = pumpDataString
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToArray();

                    pumpsData.Enqueue(pumpDataString);

                    currentPetrolAmount += pumpData[0];
                    currentPetrolAmount -= pumpData[1];

                    if (currentPetrolAmount < 0)
                    {
                        isSuccessful = false;
                    }
                }

                if (isSuccessful)
                {
                    Console.WriteLine(i);
                    break;
                }

                var tempData = pumpsData.Dequeue();
                pumpsData.Enqueue(tempData);
            }
        }
    }
}
