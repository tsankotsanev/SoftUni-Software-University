using System;
using System.Collections.Generic;
using System.Linq;
using _02.ShoppingSpree.Model;

namespace _02.ShoppingSpree.Core
{
    public class Engine
    {
        private List<Product> products;
        private List<Person> people;
        public Engine()
        {
            products = new List<Product>();
            people = new List<Person>();
        }

        public void Run()
        {
            ParsePeopleInput();
            ParseProductInput();

            string command;

            while ((command = Console.ReadLine()) != "END")
            {
                var input = command.Split(" ").ToArray();
                var personName = input[0];
                var productName = input[1];

                try
                {
                    var person = people.First(p => p.Name == personName);
                    var product = products.First(p => p.Name == productName);

                    person.BuyProduct(product);

                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            foreach (var person1 in people)
            {
                Console.WriteLine(person1.ToString());
            }
        }

        private void ParseProductInput()
        {
            var productToBuy = Console
                            .ReadLine()
                            .Split(';', StringSplitOptions.RemoveEmptyEntries)
                            .ToArray();

            foreach (var product in productToBuy)
            {
                var split = product
                    .Split('=', StringSplitOptions.None)
                    .ToArray();

                var name = split[0];
                var cost = decimal.Parse(split[1]);

                products.Add(new Product(name, cost));
            }
        }

        private void ParsePeopleInput()
        {
            var cmdArgs = Console
                  .ReadLine()
                  ?.Split(';', StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            foreach (var cmd in cmdArgs)
            {
                var splittedArgs = cmd
                    .Split("=", StringSplitOptions.None)
                    .ToArray();

                var name = splittedArgs[0];
                var money = decimal.Parse(splittedArgs[1]);

                people.Add(new Person(name, money));
            }
        }
    }
}
