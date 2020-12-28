using System;

namespace SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            var degrees = double.Parse(Console.ReadLine());
            var timeOfTheDay = Console.ReadLine();
            var outfit = string.Empty;
            var shoes = string.Empty;

            if (degrees >= 10 && degrees <= 18)
            {
                if (timeOfTheDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeOfTheDay == "Afternoon" || timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            else if (degrees > 18 && degrees <= 24)
            {
                if (timeOfTheDay == "Morning" || timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            if (degrees >= 25)
            {
                if (timeOfTheDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeOfTheDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeOfTheDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {degrees} degrees, get your {outfit} and {shoes}.");
        }
    }
}
