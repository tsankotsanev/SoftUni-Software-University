using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            var rooms = Console.ReadLine()
                .Split("|")
                .ToArray();

            var health = 100;
            var bitcoins = 0;
            var isAlive = true;

            for (var room = 0; room < rooms.Length; room++)
            {
                var currentRoom = rooms[room];
                var tokens = currentRoom.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var amount = int.Parse(tokens[1]);

                if (action == "potion")
                {
                    health += amount;

                    if (health <= 100)
                    {
                        Console.WriteLine($"You healed for {amount} hp.");
                    }
                    else
                    {
                        var missingHealth = Math.Abs((health - 100) - amount);
                        Console.WriteLine($"You healed for {missingHealth} hp.");
                        health = 100;
                    }

                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (action == "chest")
                {
                    bitcoins += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    health -= amount;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {action}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {action}.");
                        Console.WriteLine($"Best room: {room + 1}");
                        isAlive = false;
                        break;
                    }
                }
            }

            if (isAlive)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
