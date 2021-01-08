using System;
using System.Linq;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            var groceries = Console.ReadLine()
                .Split("!",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = Console.ReadLine();
            
            while (command != "Go Shopping!")
            {
                var tokens = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var item = tokens[1];

                switch (action)
                {
                    case "Urgent":
                        if (!groceries.Contains((item)))
                        {
                            groceries.Insert(0, item);
                        }
                        break;
                    case "Unnecessary":
                        if (groceries.Contains(item))
                        {
                            groceries.RemoveAt(groceries.IndexOf(item));
                        }
                        break;
                    case "Correct":
                        var newItem = tokens[2];

                        if (groceries.Contains(item))
                        {
                            var indexOfOldItem = groceries.IndexOf(item);
                            groceries.RemoveAt(groceries.IndexOf(item));
                            groceries.Insert(indexOfOldItem, newItem);
                        }
                        break;
                    case "Rearrange":
                        if (groceries.Contains(item))
                        {
                            groceries.RemoveAt(groceries.IndexOf(item));
                            groceries.Add(item);
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", groceries));
        }
    }
}
