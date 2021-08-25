using System;
using System.Linq;

namespace _08.Threeuple
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var tuple1 = new Threeuple<string, string, string>(input[0] + " " + input[1], input[2], input[3]);
            Console.WriteLine(tuple1);

            input = Console.ReadLine().Split();
            var isDrunk = input[2] == "drunk" ? true : false;
            var tuple2 = new Threeuple<string, int, bool>(input[0], int.Parse(input[1]), isDrunk);
            Console.WriteLine(tuple2);

            input = Console.ReadLine().Split();
            var tuple3 = new Threeuple<string, double, string>(input[0], double.Parse(input[1]), input[2]);
            Console.WriteLine(tuple3);
        }
    }
}
