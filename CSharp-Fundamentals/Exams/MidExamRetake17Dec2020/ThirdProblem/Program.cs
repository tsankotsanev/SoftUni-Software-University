using System;
using System.Linq;

namespace ThirdProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = Console.ReadLine()
                .Split("|",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = "";

            while ((command = Console.ReadLine()) != "Shop!")
            {
                var tokens = command.Split("%",
                    StringSplitOptions.RemoveEmptyEntries);

                var action = tokens[0];
                var product = tokens[1];

                switch (action)
                {
                    case "Important":
                        if (products.Contains(product))
                        {
                            products.Remove(product);
                            products.Insert(0, product);
                        }
                        else
                        {
                            products.Insert(0, product);
                        }
                        break;
                    case "Add":
                        if (products.Contains(product))
                        {
                            Console.WriteLine("The product is already in the list.");
                        }
                        else
                        {
                            products.Add(product);
                        }
                        break;
                    case "Swap":
                        var secondProduct = tokens[2];
                        if (!products.Contains(product))
                        {
                            Console.WriteLine($"Product {product} missing!");
                        }
                        else if (!products.Contains(secondProduct))
                        {
                            Console.WriteLine($"Product {secondProduct} missing!");
                        }
                        else
                        {
                            var firstProductIndex = products.IndexOf(product);
                            var secondProductIndex = products.IndexOf(secondProduct);

                            products.Remove(product);
                            products.Remove(secondProduct);

                            products.Insert(firstProductIndex, secondProduct);
                            products.Insert(secondProductIndex, product);
                        }
                        break;
                    case "Remove":
                        if (products.Contains(product))
                        {
                            products.Remove(product);
                        }
                        else
                        {
                            Console.WriteLine($"Product {product} isn't in the list.");
                        }
                        break;
                }
            }

            for (var i = 0; i < products.Count; i++)
            {
                var currentProduct = products[i];
                var numberOfTheProduct = i + 1;

                Console.WriteLine($"{numberOfTheProduct}. {currentProduct}");

            }
        }
    }
}
