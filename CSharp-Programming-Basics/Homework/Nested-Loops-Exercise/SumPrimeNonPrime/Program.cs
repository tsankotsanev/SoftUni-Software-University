using System;


namespace SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int sumPrime = 0;
            int sumNonprime = 0;

            while (input != "stop")
            {
                bool isPrime = true;
                int n = int.Parse(input);
                if (n < 0)
                {
                    n = 0;
                    Console.WriteLine("Number is negative.");

                }

                else if (n == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int count = 2; count <= n; count++)
                    {
                        if (n % count == 0 && count != n)

                        {
                            isPrime = false;

                            break;
                        }
                    }

                }
                if (isPrime)
                {
                    sumPrime += n;
                }
                else if (isPrime == false)
                {
                    sumNonprime += n;
                }
                input = Console.ReadLine();
            }
            if (input == "stop")
            {
                Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                Console.WriteLine($"Sum of all non prime numbers is: {sumNonprime}");
            }
        }
    }
}