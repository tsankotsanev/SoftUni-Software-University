using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberOfRegistrations = int.Parse(Console.ReadLine());
            var pattern = @"U\$(?<username>[A-Z][a-z]{2,})U\$P\@\$(?<password>[a-z]{5,}\d+)P\@\$";
            var registrationRegex = new Regex(pattern);
            var successfulRegistrationsCount = 0;
            var username = string.Empty;
            var password = string.Empty;

            for (var i = 0; i < numberOfRegistrations; i++)
            {
                var registration = Console.ReadLine();
                var matches = Regex.Matches(registration, pattern);

                if (registrationRegex.IsMatch(registration))
                {
                    foreach (Match match in matches)
                    {
                        username = match.Groups["username"].Value;
                        password = match.Groups["password"].Value;
                    }

                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {username}, Password: {password}");

                    successfulRegistrationsCount++;
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {successfulRegistrationsCount}");
        }
    }
}