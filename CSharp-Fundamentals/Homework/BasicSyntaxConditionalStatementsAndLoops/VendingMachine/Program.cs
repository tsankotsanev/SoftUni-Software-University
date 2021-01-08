using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            var coins = Console.ReadLine();

            var totalSum = 0m;

            while (coins != "Start")
            {
                var currentAmount = decimal.Parse(coins);

                if (currentAmount != 0.1m
                    && currentAmount != 0.2m
                    && currentAmount != 0.5m
                    && currentAmount != 1m
                    && currentAmount != 2m)
                {
                    Console.WriteLine($"Cannot accept {currentAmount}");
                }
                else
                {
                    totalSum += currentAmount;
                }

                coins = Console.ReadLine();
            }

            var input = Console.ReadLine().ToLower();

            while (input != "end")
            {

                decimal currentPrice = 0;
                var invalidProduct = false;

                switch (input)
                {
                    case "nuts":
                        currentPrice = 2.0m;
                        break;
                    case "water":
                        currentPrice = 0.7m;
                        break;
                    case "crisps":
                        currentPrice = 1.5m;
                        break;
                    case "soda":
                        currentPrice = 0.8m;
                        break;
                    case "coke":
                        currentPrice = 1.0m;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        invalidProduct = true;
                        break;
                }

                if (invalidProduct == false)
                {
                    if (totalSum >= currentPrice)
                    {
                        totalSum -= currentPrice;
                        Console.WriteLine($"Purchased {input.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }

                input = Console.ReadLine().ToLower();
            }

            Console.WriteLine($"Change: {totalSum:F2}");
        }
    }
}