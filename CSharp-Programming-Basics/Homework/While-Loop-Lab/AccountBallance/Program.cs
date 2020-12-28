using System;

namespace AccountBallance
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var savedMoney = 0.0;

            while (input != "NoMoreMoney")
            {
                var inputMoney = double.Parse(input);

                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {inputMoney:F2}");

                savedMoney += inputMoney;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {savedMoney:F2}");
        }
    }
}
