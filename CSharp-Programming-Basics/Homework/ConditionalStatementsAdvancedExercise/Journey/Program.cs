using System;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            var season = Console.ReadLine();
            var moneySpent = 0.0;
            var placeToRest = string.Empty;
            var destination = string.Empty;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    destination = "Bulgaria";
                    placeToRest = "Camp";
                    moneySpent = budget - (budget * 0.70);
                }
                else if (season == "winter")
                {
                    destination = "Bulgaria";
                    placeToRest = "Hotel";
                    moneySpent = budget - (budget * 0.30);
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    destination = "Balkans";
                    placeToRest = "Camp";
                    moneySpent = budget - (budget * 0.60);
                }
                else if (season == "winter")
                {
                    destination = "Balkans";
                    placeToRest = "Hotel";
                    moneySpent = budget - (budget * 0.20);
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                placeToRest = "Hotel";
                moneySpent = budget - (budget * 0.10);
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToRest} - {moneySpent:F2}");
        }
    }
}
