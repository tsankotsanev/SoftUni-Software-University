using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "Stop")
            {
                Console.WriteLine(input);

                input = Console.ReadLine();
            }
        }
    }
}
