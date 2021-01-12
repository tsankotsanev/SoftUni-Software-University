using System;
using System.Collections.Generic;

namespace SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var commandsCount = int.Parse(Console.ReadLine());

            var registrations = new Dictionary<string, string>();

            for (var i = 0; i < commandsCount; i++)
            {
                var command = Console.ReadLine();

                var splitCommand = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var action = splitCommand[0];
                var username = splitCommand[1];

                switch (action)
                {
                    case "register":
                        {
                            var license = splitCommand[2];

                            if (!registrations.ContainsKey(username) ||
                                !registrations.ContainsValue(license))
                            {
                                registrations.Add(username, license);
                                Console.WriteLine($"{username} registered {license} successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {license}");
                            }

                            break;
                        }
                    case "unregister":
                        {
                            if (registrations.ContainsKey(username))
                            {
                                registrations.Remove(username);
                                Console.WriteLine($"{username} unregistered successfully");
                            }
                            else
                            {
                                Console.WriteLine($"ERROR: user {username} not found");
                            }

                            break;
                        }
                }
            }

            foreach (var (key, value) in registrations)
            {
                Console.WriteLine($"{key} => {value}");
            }
        }
    }
}