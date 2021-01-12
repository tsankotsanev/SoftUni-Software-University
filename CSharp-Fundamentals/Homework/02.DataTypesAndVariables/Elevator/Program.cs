using System;

namespace Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());

            var courses = (int) Math.Ceiling((double) people / capacity);

            Console.WriteLine(courses);
        }
    }
}