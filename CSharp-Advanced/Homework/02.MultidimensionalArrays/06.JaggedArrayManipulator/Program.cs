using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = int.Parse(Console.ReadLine());
            var jaggedArray = new double[dimensions][];

            for (var row = 0; row < jaggedArray.Length; row++)
            {
                jaggedArray[row] = Console
                    .ReadLine()
                    ?.Split(" "
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }

            for (var rows = 0; rows < jaggedArray.Length - 1; rows++)
            {
                if (jaggedArray[rows].Length == jaggedArray[rows + 1].Length)
                {
                    for (var cols = 0; cols < jaggedArray[rows].Length; cols++)
                    {
                        jaggedArray[rows][cols] *= 2;
                        jaggedArray[rows + 1][cols] *= 2;
                    }
                    continue;
                }
                for (var cols = 0; cols < jaggedArray[rows].Length; cols++)
                {
                    jaggedArray[rows][cols] /= 2;
                }
                for (var cols = 0; cols < jaggedArray[rows + 1].Length; cols++)
                {
                    jaggedArray[rows + 1][cols] /= 2;
                }

            }
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command
                          .Split()
                          .ToArray();

                var row = int.Parse(splitCommand[1]);
                var column = int.Parse(splitCommand[2]);
                var value = int.Parse(splitCommand[3]);

                if (!IsValid(jaggedArray, row, column))
                {
                    continue;
                }
                switch (splitCommand[0])
                {
                    case "Add":
                        jaggedArray[row][column] += value;
                        break;
                    case "Subtract":
                        jaggedArray[row][column] -= value;
                        break;
                }
            }

            PrintJagged(jaggedArray);
        }

        private static void PrintJagged(double[][] jaggedArr)
        {
            foreach (var row in jaggedArr)
            {
                Console.WriteLine($"{string.Join(" ", row)}");
            }
        }

        private static bool IsValid(double[][] jaggedArray, int row, int column)
        {
            return row >= 0 && row < jaggedArray.Length
               && column >= 0 && column < jaggedArray[row].Length;

        }
    }
}
