using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.GenericCountMethodString
{
    public class Program
    {
        static void Main(string[] args)
        {

            var count = int.Parse(Console.ReadLine());
            var box = new Box<string>();

            for (var i = 0; i < count; i++)
            {
                var element = Console.ReadLine();


                box.StoreElement.Add(element);
            }
            var compareElement = Console.ReadLine();
            Console.WriteLine(box.GreaterThan(compareElement));

        }
    }
}
