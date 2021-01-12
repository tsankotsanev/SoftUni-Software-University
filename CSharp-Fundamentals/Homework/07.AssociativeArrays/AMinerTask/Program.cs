using System;
using System.Collections.Generic;

namespace AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();

            var currentResource = string.Empty;

            while ((currentResource = Console.ReadLine()) != "stop")
            {
                var quantity = int.Parse(Console.ReadLine());

                if (resources.ContainsKey(currentResource))
                {
                    resources[currentResource] += quantity;
                }
                else
                {
                    resources[currentResource] = quantity;
                }
            }

            foreach (var (key, value) in resources)
            {
                Console.WriteLine($"{key} -> {value}");
            }
        }
    }
}