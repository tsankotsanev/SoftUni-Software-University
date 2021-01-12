using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double OddSum = 0;
            double EvenSum = 0;
            double OddMin = double.MaxValue;
            double OddMax = double.MinValue;
            double EvenMin = double.MaxValue;
            double EvenMax = double.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    double NumberEven = double.Parse(Console.ReadLine());
                    EvenSum += NumberEven;

                    if (NumberEven < EvenMin)
                    {
                        EvenMin = NumberEven;
                    }
                    if (NumberEven > EvenMax)
                    {
                        EvenMax = NumberEven;
                    }
                }
                else
                {
                    double NumberOdd = double.Parse(Console.ReadLine());
                    OddSum += NumberOdd;
                    if (NumberOdd < OddMin)
                    {
                        OddMin = NumberOdd;
                    }
                    if (NumberOdd > OddMax)
                    {
                        OddMax = NumberOdd;
                    }

                }
            }
            if (n == 0)
            {
                Console.WriteLine($"OddSum={OddSum:F2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
                Console.WriteLine($"EvenSum={EvenSum:F2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else if ((EvenMin == double.MaxValue) || (EvenMax == double.MinValue))
            {                     
                Console.WriteLine($"OddSum={OddSum:F2},");
                Console.WriteLine($"OddMin={OddMin:F2},");
                Console.WriteLine($"OddMax={OddMax:F2},");
                Console.WriteLine($"EvenSum={EvenSum:F2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
            else
            {
                Console.WriteLine($"OddSum={OddSum:F2},");
                Console.WriteLine($"OddMin={OddMin:F2},");
                Console.WriteLine($"OddMax={OddMax:F2},");
                Console.WriteLine($"EvenSum={EvenSum:F2},");
                Console.WriteLine($"EvenMin={EvenMin:F2},");
                Console.WriteLine($"EvenMax={EvenMax:F2}");
            }

        }
    }
}
