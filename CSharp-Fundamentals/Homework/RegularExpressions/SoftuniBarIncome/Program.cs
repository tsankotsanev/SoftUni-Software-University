using System;
using System.Text.RegularExpressions;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>[-+]?[0-9]*\.?[0-9]+([eE][-+]?[0-9]+)?)\$";
            var totalIncome = 0.0;

            var input = string.Empty;

            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    var match = Regex.Match(input, pattern);

                    var customer = match.Groups["customer"].Value;
                    var product = match.Groups["product"].Value;
                    var count = int.Parse(match.Groups["count"].Value);
                    var price = double.Parse(match.Groups["price"].Value);

                    var money = price * count;

                    Console.WriteLine($"{customer}: {product} - {money:F2}");

                    totalIncome += money;
                }
            }
            Console.WriteLine($"Total income: {totalIncome:F2}");
        }
    }
}