using System;
using System.Linq;

namespace HeartDelivery
{
    class exam
    {
        static void Main(string[] args)
        {
            var houses = Console.ReadLine()
                .Split("@",
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var command = Console.ReadLine().Split(" ",
                StringSplitOptions.RemoveEmptyEntries);
            

            var lastPosition = 0;

            while (command[0] != "Love!")
            {
                var distance = int.Parse(command[1]);
                var currentIndex = lastPosition + distance;

                if (currentIndex >= houses.Count)
                {
                    currentIndex = 0;
                }

                if (houses[currentIndex] > 0)
                {
                    houses[currentIndex] -= 2;

                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }

                lastPosition = currentIndex;

                command = Console.ReadLine()
                    .Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine($"Cupid's last position was {lastPosition}.");

            if (houses.Sum() == 0)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                var count = houses.Count(points => points > 0);

                Console.WriteLine($"Cupid has failed {count} places.");
            }
        }
    }
}