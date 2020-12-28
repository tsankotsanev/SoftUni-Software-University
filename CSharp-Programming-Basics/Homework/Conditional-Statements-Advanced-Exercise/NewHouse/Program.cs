using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            var flowers = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());
            var finalPrice = 0.0;

            var roses = 5.00;
            var dahlias = 3.80;
            var tulips = 2.80;
            var narcissus = 3.00;
            var gladiolus = 2.50;

            if (flowers == "Roses")
            {
                finalPrice = roses * quantity;

                if (quantity > 80)
                {
                    finalPrice -= finalPrice * 0.10;
                }
            }
            else if (flowers == "Dahlias")
            {
                finalPrice = dahlias * quantity;

                if (quantity > 90)
                {
                    finalPrice -= finalPrice * 0.15;
                }
            }
            else if (flowers == "Tulips")
            {
                finalPrice = tulips * quantity;

                if (quantity > 80)
                {
                    finalPrice -= finalPrice * 0.15;
                }
            }
            else if (flowers == "Narcissus")
            {
                finalPrice = narcissus * quantity;

                if (quantity < 120)
                {
                    finalPrice += finalPrice * 0.15;
                }
            }
            else if (flowers == "Gladiolus")
            {
                finalPrice = gladiolus * quantity;

                if (quantity < 80)
                {
                    finalPrice += finalPrice * 0.20;
                }
            }
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {budget - finalPrice:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {finalPrice - budget:F2} leva more.");
            }
        }
    }
}
