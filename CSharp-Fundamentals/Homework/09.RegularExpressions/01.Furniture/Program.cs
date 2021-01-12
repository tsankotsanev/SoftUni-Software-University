using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            var items = new List<string>();
            var totalPrice = 0.0;

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Purchase")
            {
                var match = Regex.Match(input, regex, RegexOptions.IgnoreCase);

                if (match.Success)
                {
                    var name = match.Groups["name"].Value;
                    var price = double.Parse(match.Groups["price"].Value);
                    var quantity = int.Parse(match.Groups["quantity"].Value);

                    items.Add(name);
                    totalPrice += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");

            if (items.Count > 0)
            {
                Console.WriteLine($"{string.Join(Environment.NewLine, items)}");
            }

            Console.WriteLine($"Total money spend: {totalPrice:F2}");
        }
    }
}