using System;

namespace OperationsBetweenNum
{
    class Program
    {
        
            static void Main(string[] args)
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = 0;

                if (operation == "+")
                {
                    result = n1 + n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                }
                else if (operation == "-")
                {
                    result = n1 - n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                }
                else if (operation == "*")
                {
                    result = n1 * n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                }

                else if (operation == "%")
                {
                    if (n2 != 0)
                    {

                        Console.WriteLine($"{n1} % {n2} = {n1 % n2}");
                    }
                    else { Console.WriteLine($"Cannot divide {n1} by zero"); }


                }
                else if (operation == "/")
                {
                    if (n2 != 0) { Console.WriteLine($"{n1} / {n2} = {n1 * 1.0 / n2:F2}"); }
                    else { Console.WriteLine($"Cannot divide {n1} by zero"); }
                }

            }
        }
    }
