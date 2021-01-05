using System;
using System.Linq;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var email = Console.ReadLine();
            var command = Console.ReadLine();

            while (command != "Complete")
            {
                var tokens = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];

                switch (action)
                {
                    case "Make":
                        var lowerOrUpper = tokens[1];

                        email = lowerOrUpper == "Upper" ? email.ToUpper() : email.ToLower();
                        break;
                    case "GetDomain":
                        var count = int.Parse(tokens[1]);

                        Console.WriteLine(email[^count..]);
                        break;
                    case "GetUsername":
                        if (email.Contains('@'))
                        {
                            var atLocation = email.IndexOf('@');

                            Console.WriteLine(email[..atLocation]);
                        }
                        else
                        {
                            Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                        }
                        break;
                    case "Replace":
                        var charToReplace = char.Parse(tokens[1]);

                        email = email.Replace(charToReplace, '-');
                        break;
                    case "Encrypt":
                        var ASCII = email
                            .Select(e => (int)e);

                        Console.WriteLine(string.Join(" ", ASCII));
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}