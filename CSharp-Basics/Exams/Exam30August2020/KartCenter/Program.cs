using System;

namespace KartCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSum = double.Parse(Console.ReadLine());
            var spins = Console.ReadLine();
            var fanCard = Console.ReadLine();
            var kart = Console.ReadLine();

            var price = 0.0;

            switch (spins)
            {
                case "five":
                    if (kart == "Child")
                    {
                        price = 7;
                    }
                    else if (kart == "Junior")
                    {
                        price = 9;
                    }
                    else if (kart == "Adult")
                    {
                        price = 12;
                    }
                    else if ( kart == "Profi")
                    {
                        price = 18;
                    }
                    break;
                case "ten":
                    if (kart == "Child")
                    {
                        price = 11;
                    }
                    else if (kart == "Junior")
                    {
                        price = 16;
                    }
                    else if (kart == "Adult")
                    {
                        price = 21;
                    }
                    else if (kart == "Profi")
                    {
                        price = 32;
                    }
                    break;
            }

            if (fanCard == "yes")
            {
                price -= price * 0.20;
            }

            if (price <= inputSum)
            {
                Console.WriteLine($"You bought {kart} ticket for {spins} laps. Your change is {Math.Abs(inputSum - price):F2}lv.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need {Math.Abs(price - inputSum):F2}lv more.");
            }
        }
    }
}
