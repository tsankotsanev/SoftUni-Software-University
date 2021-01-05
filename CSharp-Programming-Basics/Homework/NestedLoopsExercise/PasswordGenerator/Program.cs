using System;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var l = int.Parse(Console.ReadLine());
            var letter = 97 + l;

            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    for (int k = 97; k < letter; k++)
                    {
                        for (int m = 97; m < letter; m++)
                        {
                            for (int o = 1; o <= n ; o++)
                            {
                                if (o > i && o > j)
                                {
                                    Console.Write($"{i}{j}{(char)k}{(char)m}{o} ");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
