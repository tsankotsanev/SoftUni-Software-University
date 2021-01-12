using System;

namespace TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            var city = Console.ReadLine();
            var sales = double.Parse(Console.ReadLine());

            if (sales >= 0 && sales <= 500)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", sales * 0.05);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", sales * 0.045);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", sales * 0.055);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", sales * 0.07);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", sales * 0.075);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", sales * 0.08);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", sales * 0.08);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", sales * 0.10);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", sales * 0.12);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        Console.WriteLine("{0:F2}", sales * 0.12);
                        break;
                    case "Varna":
                        Console.WriteLine("{0:F2}", sales * 0.13);
                        break;
                    case "Plovdiv":
                        Console.WriteLine("{0:F2}", sales * 0.145);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }

        }
    }
}
