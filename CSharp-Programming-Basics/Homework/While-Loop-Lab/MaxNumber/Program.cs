using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var maxNumber = int.MinValue;

            while (input != "Stop")
            {
                var inputNumber = int.Parse(input);

                if (inputNumber > maxNumber)
                {
                    maxNumber = inputNumber;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(maxNumber);
        }
    }
}
