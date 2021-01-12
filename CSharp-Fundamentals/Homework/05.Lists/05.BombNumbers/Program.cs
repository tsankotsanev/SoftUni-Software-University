using System;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            var numbersToDetonate = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var specialNumber = numbersToDetonate[0];
            var detonationPower = numbersToDetonate[1];

            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == specialNumber)
                {
                    for (var j = 0; j < detonationPower; j++)
                    {
                        var leftIndex = i - 1;

                        if (leftIndex == 0)
                        {
                            numbers.RemoveAt(leftIndex);
                            i -= 1;
                            break;
                        }

                        if (leftIndex < 0)
                        {
                            break;
                        }

                        if (leftIndex > 0)
                        {
                            numbers.RemoveAt(leftIndex);
                            i -= 1;
                        }
                    }
                    for (var j = 0; j < detonationPower; j++)
                    {
                        var rightIndex = i + 1;

                        if (rightIndex == numbers.Count - 1)
                        {
                            numbers.RemoveAt(rightIndex);
                            break;
                        }

                        if (rightIndex > numbers.Count - 1)
                        {
                            break;
                        }

                        if (rightIndex < numbers.Count - 1)
                        {
                            numbers.RemoveAt(rightIndex);
                        }
                    }

                    numbers.Remove(specialNumber);
                    i = -1;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}