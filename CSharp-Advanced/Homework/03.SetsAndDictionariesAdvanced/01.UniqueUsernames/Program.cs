using System;
using System.Collections.Generic;

namespace _01.UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var userNames = new HashSet<string>();

            for (var i = 0; i < n; i++)
            {
                var name = Console.ReadLine();

                userNames.Add(name);

            }

            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}