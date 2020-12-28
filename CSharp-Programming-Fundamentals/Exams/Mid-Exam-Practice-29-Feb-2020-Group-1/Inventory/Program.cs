using System;
using System.Linq;

namespace Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            var journal = Console.ReadLine()
                .Split(", ")
                .ToList();

            var command = Console.ReadLine();

            while (command != "Craft!")
            {
                var tokens = command.Split(" - ");
                var action = tokens[0];
                var item = tokens[1];

                switch (action)
                {
                    case "Collect":
                        {
                            if (!journal.Contains(item))
                            {
                                journal.Add(item);
                            }

                            break;
                        }
                    case "Drop":
                        {
                            if (journal.Contains(item))
                            {
                                journal.Remove(item);
                            }

                            break;
                        }
                    case "Combine Items":
                        {
                            var itemArgs = item.Split(":");
                            var oldItem = itemArgs[0];
                            var newItem = itemArgs[1];

                            if (journal.Contains(oldItem))
                            {
                                var oldItemIndex = journal.IndexOf(oldItem);

                                journal.Insert(oldItemIndex + 1, newItem);
                            }

                            break;
                        }
                    case "Renew":
                        {
                            if (journal.Contains(item))
                            {
                                journal.Remove(item);
                                journal.Add(item);
                            }

                            break;
                        }
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
