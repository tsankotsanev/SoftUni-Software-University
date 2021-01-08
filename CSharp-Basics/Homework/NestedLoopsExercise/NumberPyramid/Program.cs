using System;

namespace NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var current = 1;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    if (current > n)
                    {
                        goto End;
                    }

                    Console.Write(current + " ");
                    current++;
                }
                Console.WriteLine();
            End:;
            }

        }
    }
}
