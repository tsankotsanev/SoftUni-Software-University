using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var uniqueChemicalCompounds = new SortedSet<string>();

            for (var i = 0; i < count; i++)
            {
                var chemicalCompounds = Console
                    .ReadLine()
                    ?.Split()
                    .ToArray();

                foreach (var compound in chemicalCompounds)
                {
                    uniqueChemicalCompounds.Add(compound.ToString());
                }
            }

            foreach (var compound in uniqueChemicalCompounds)
            {
                Console.Write(compound + " ");
            }
        }
    }
}