﻿using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            PrintMatrix(number);
        }

        private static void PrintMatrix(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
