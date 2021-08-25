using System;

namespace _06.GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = int.Parse(Console.ReadLine());
            var box = new Box<double>();

            for (var i = 0; i < count; i++)
            {
                var numebr = double.Parse(Console.ReadLine());



                box.StoreElement.Add(numebr);
            }
            var compareNumber = double.Parse(Console.ReadLine());

            Console.WriteLine(box.GreaterThan(compareNumber));

        }
    }
}
