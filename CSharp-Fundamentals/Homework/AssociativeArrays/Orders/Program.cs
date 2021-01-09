using System;
using System.Linq;
using System.Collections.Generic;

namespace _04Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = new Dictionary<string, double[]>();

            var command = "";

            while ((command = Console.ReadLine()) != "buy")
            {
                var splitCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var product = splitCommand[0];
                var price = double.Parse(splitCommand[1]);
                var quantity = int.Parse(splitCommand[2]);

                if (products.ContainsKey(product))
                {
                    products[product][0] = price;
                    products[product][1] += quantity;
                }
                else
                {
                    products[product] = new double[2];
                    products[product][0] = price;
                    products[product][1] = quantity;
                }
            }

            foreach (var (key, value) in products)
            {
                var totalPrice = value[0] * value[1];
                Console.WriteLine($"{key} -> {totalPrice:F2}");
            }
        }
    }
}