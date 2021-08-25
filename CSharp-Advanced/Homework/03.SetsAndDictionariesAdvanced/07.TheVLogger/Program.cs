using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheVLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            var vloggers = new Dictionary<string, Dictionary<string, SortedSet<string>>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "Statistics")
            {
                var inputInfo = input
                              .Split(" ")
                              .ToArray();

                switch (inputInfo[1])
                {
                    case "joined":
                        {
                            var vloggerName = inputInfo[0];

                            if (!vloggers.ContainsKey(vloggerName))
                            {
                                vloggers.Add(vloggerName, new Dictionary<string, SortedSet<string>>());
                                vloggers[vloggerName].Add("following", new SortedSet<string>());
                                vloggers[vloggerName].Add("followers", new SortedSet<string>());
                            }

                            break;
                        }
                    case "followed":
                        {
                            var firstVlogger = inputInfo[0];
                            var secondVlogger = inputInfo[2];
                            if (vloggers.ContainsKey(firstVlogger) && vloggers.ContainsKey(secondVlogger))
                            {
                                if (vloggers[firstVlogger] != vloggers[secondVlogger])
                                {

                                    vloggers[firstVlogger]["following"].Add(secondVlogger);
                                    vloggers[secondVlogger]["followers"].Add(firstVlogger);

                                }
                            }

                            break;
                        }
                }
            }
            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            var count = 1;

            var orderedVlogger = vloggers
               .OrderByDescending(x => x.Value["followers"].Count)
               .ThenBy(x => x.Value["following"].Count)
               .ToDictionary(x => x.Key, v => v.Value);

            foreach (var vlogger in orderedVlogger)
            {
                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value["followers"].Count} followers," +
                    $" {vlogger.Value["following"].Count} following");
                if (count == 1)
                {
                    foreach (var followers in vlogger.Value["followers"])
                    {

                        Console.WriteLine($"*  {followers}");

                    }
                }
                count++;
            }
        }
    }
}