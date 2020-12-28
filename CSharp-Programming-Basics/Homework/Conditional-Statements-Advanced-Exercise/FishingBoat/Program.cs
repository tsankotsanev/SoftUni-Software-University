using System;

namespace FishingBoat
{

    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermanNum = int.Parse(Console.ReadLine());

            decimal boatPrice = 0;
            switch (season)
            {
                case "Spring":
                    boatPrice = 3000m;
                    break;
                case "Summer":
                case "Autumn":
                    boatPrice = 4200m;
                    break;
                case "Winter":
                    boatPrice = 2600m;
                    break;
            }

            if (fishermanNum <= 6)
            {
                boatPrice = boatPrice - (boatPrice * 0.10m);
            }
            else if (fishermanNum > 7 && fishermanNum <= 11)
            {
                boatPrice = boatPrice - (boatPrice * 0.15m);
            }
            else if (fishermanNum > 12)
            {
                boatPrice = boatPrice - (boatPrice * 0.25m);
            }

            if (fishermanNum % 2 == 0 && season != "Autumn")
            {
                boatPrice = boatPrice - (boatPrice * 0.05m);
            }

            if (budget >= boatPrice)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budget - boatPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(budget - boatPrice):F2} leva.");
            }
        }
    }
}

