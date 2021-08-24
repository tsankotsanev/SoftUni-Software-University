using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            var waves = int.Parse(Console.ReadLine());
            var plates = new LinkedList<int>(Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray());

            var orcs = new Stack<int>();

            for (var i = 1; i <= waves; i++)
            {
                orcs = new Stack<int>(Console
                   .ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(int.Parse)
                   .ToArray());

                if (i % 3 == 0)
                {
                    plates.AddLast(int.Parse(Console.ReadLine()));
                }

                while (orcs.Any())
                {
                    if (!plates.Any())
                    {
                        goto LoopEnd;
                    }

                    var orcAttack = orcs.Peek();
                    var plateDefense = plates.First();

                    if (orcAttack > plateDefense)
                    {
                        plates.RemoveFirst();
                        orcs.Pop();
                        orcs.Push(orcAttack - plateDefense);
                    }
                    else if (orcAttack < plateDefense)
                    {
                        orcs.Pop();
                        plates.RemoveFirst();
                        plates.AddFirst(plateDefense - orcAttack);
                    }
                    else
                    {
                        orcs.Pop();
                        plates.RemoveFirst();
                    }
                }
            }

        LoopEnd:

            if (plates.Any())
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", plates)}");
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", orcs)}");
            }
        }
    }
}
