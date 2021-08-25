using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var inputNumber = new Dictionary<int, List<int>>();

            for (var i = 0; i < count; i++)
            {
                var number = int.Parse(Console.ReadLine());

                if (!inputNumber.ContainsKey(number))
                {
                    inputNumber.Add(number, new List<int>());
                }
                inputNumber[number].Add(number);
            }

            foreach (var num in inputNumber.Where(num => num.Value.Count % 2 == 0))
            {
                Console.WriteLine(num.Key);
                return;
            }
        }
    }
}