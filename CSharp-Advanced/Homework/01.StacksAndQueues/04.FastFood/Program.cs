using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            var foodQuantity = int.Parse(Console.ReadLine());

            var ordersInput = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var orders = new Queue<int>(ordersInput);

            Console.WriteLine(orders.Max());

            while (orders.Count != 0)
            {
                var currentOrder = orders.Peek();

                if (currentOrder <= foodQuantity)
                {
                    orders.Dequeue();
                    foodQuantity -= currentOrder;
                }
                else
                {
                    Console.WriteLine("Orders left: " + string.Join(" ", orders));
                    Environment.Exit(0);
                }
            }

            Console.WriteLine("Orders complete");
        }
    }
}
