﻿using System;

namespace FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var fruit = Console.ReadLine();
            var day = Console.ReadLine();
            var quantity = double.Parse(Console.ReadLine());

            if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", quantity * 2.50);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", quantity * 1.20);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", quantity * 0.85);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", quantity * 1.45);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", quantity * 2.70);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", quantity * 5.50);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", quantity * 3.85);
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else if (day == "Saturday" || day == "Sunday")
            {
                switch (fruit)
                {
                    case "banana":
                        Console.WriteLine("{0:F2}", quantity * 2.70);
                        break;
                    case "apple":
                        Console.WriteLine("{0:F2}", quantity * 1.25);
                        break;
                    case "orange":
                        Console.WriteLine("{0:F2}", quantity * 0.90);
                        break;
                    case "grapefruit":
                        Console.WriteLine("{0:F2}", quantity * 1.60);
                        break;
                    case "kiwi":
                        Console.WriteLine("{0:F2}", quantity * 3.00);
                        break;
                    case "pineapple":
                        Console.WriteLine("{0:F2}", quantity * 5.60);
                        break;
                    case "grapes":
                        Console.WriteLine("{0:F2}", quantity * 4.20);
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
