using System;

namespace Train
{
    class Program
    {
        static void Main(string[] args)
        {
            var wagonsCount = int.Parse(Console.ReadLine());
            var people = new int[wagonsCount];
            var peopleSum = 0;

            for (var i = 0; i < wagonsCount; i++)
            {
                people[i] = int.Parse(Console.ReadLine());
                peopleSum += people[i];
            }

            Console.WriteLine(string.Join(" ", people));
            Console.WriteLine(peopleSum);
        }
    }
}
