using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var biscuits = Console.ReadLine()
                .Split(", ",
                    StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var command = "";

            while ((command = Console.ReadLine()) != "Eat")
            {
                var tokens = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                var action = tokens[0];
                var biscuit = tokens[1];

                switch (action)
                {
                    case "Update-Any":
                        if (biscuits.Contains(biscuit))
                        {

                            var indexOfBiscuit = biscuits.IndexOf(biscuit);

                            biscuits.Remove(biscuit);
                            biscuits.Insert(indexOfBiscuit, "Out of stock");
                        }

                        break;
                    case "Remove":
                        var index = int.Parse(tokens[2]);

                        if (index >= 0 && index <= biscuits.Count - 1)
                        {
                            var currentBiscuitIndex = biscuits.IndexOf(biscuit);

                            biscuits.RemoveAt(index);
                            biscuits.Insert(index, biscuit);
                        }
                        break;
                    case "Update-Last":
                        biscuits.Remove(biscuits[^1]);
                        biscuits.Add(biscuit);
                        break;
                    case "Rearrange":
                        if (biscuits.Contains(biscuit))
                        {
                            biscuits.Remove(biscuit);
                            biscuits.Add(biscuit);
                        }
                        break;

                }
            }

            while (biscuits.Contains("Out of stock"))
            {
                biscuits.Remove("Out of stock");
            }

            Console.WriteLine(string.Join(" ", biscuits));

        }
    }
}
