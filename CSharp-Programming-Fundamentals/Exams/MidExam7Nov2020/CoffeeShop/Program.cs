using System;

namespace CoffeeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var orders = int.Parse(Console.ReadLine());

            var totalPrice = 0.0;

            for (var i = 0; i < orders; i++)
            {
                var pricePerCapsule = double.Parse(Console.ReadLine());
                var days = int.Parse(Console.ReadLine());
                var capsulesCount = int.Parse(Console.ReadLine());

                var orderPrice = (days * capsulesCount) * pricePerCapsule;
                totalPrice += orderPrice;

                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");

                orderPrice = 0;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}