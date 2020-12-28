using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string architectName = Console.ReadLine();
            int projects = int.Parse(Console.ReadLine());
            int totalTimeNeeded = projects * 3;

            Console.WriteLine($"The architect {architectName} will need " +
            $"{totalTimeNeeded} hours to complete {projects} project/s.");
        }
    }
}
