using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var minNumber = int.MaxValue;

            while (input != "Stop")
            {
                var inputNumber = int.Parse(input);

                if (inputNumber < minNumber)
                {
                    minNumber = inputNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
