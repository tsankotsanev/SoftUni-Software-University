using System;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ",
                    StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                var splitCommand = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);

                var action = splitCommand[0];
                var element = int.Parse(splitCommand[1]);

                switch (action)
                {
                    case "Delete":
                        while (numbers.Contains(element))
                        {
                            numbers.Remove(element);
                        }
                        break;
                    case "Insert":
                        var index = int.Parse(splitCommand[2]);

                        numbers.Insert(index, element);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
