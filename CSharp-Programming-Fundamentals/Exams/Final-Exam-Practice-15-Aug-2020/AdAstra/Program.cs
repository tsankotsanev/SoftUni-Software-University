using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"(\||#)(?<food>[A-Za-z ]+)\1(?<expdate>(?:0?[1-9]|[12][0-9]|3[01])[\/\-](?:0?[1-9]|1[012])[\/]\d{2})\1(?<calories>\d+)\1";

            var matches = Regex.Matches(input, pattern);
            var totalCalories = 0.0;

            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }

            var foodToLast = Math.Floor(totalCalories / 2000);

            Console.WriteLine($"You have food to last you for: {foodToLast} days!");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["food"]}, Best before: {match.Groups["expdate"]}, Nutrition: {match.Groups["calories"]}");
            }
        }
    }
}
