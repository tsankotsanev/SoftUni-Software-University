using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            var roses = new Queue<int>(Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            var lilies = new Stack<int>(Console
                .ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray());

            var wreaths = 0;
            var flowers = 0;

            while (roses.Any() && lilies.Any())
            {
                var lili = lilies.Pop();
                var rose = roses.Dequeue();
                var sum = lili + rose;

                if (sum == 15)
                {
                    wreaths++;
                }
                else if (sum < 15)
                {
                    flowers += sum;
                }
                else
                {
                    if (sum % 2 == 0)
                    {
                        flowers += 14;
                    }
                    else
                    {
                        wreaths++;
                    }
                }
            }

            wreaths += flowers / 15;

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                var wreathsNeeded = 5 - wreaths;
                Console.WriteLine($"You didn't make it, you need {wreathsNeeded} wreaths more!");
            }
        }
    }
}
