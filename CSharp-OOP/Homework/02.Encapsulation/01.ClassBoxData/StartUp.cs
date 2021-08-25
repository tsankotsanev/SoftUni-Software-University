using _01.ClassBoxData.Common;
using System;

namespace _01.ClassBoxData
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            try
            {
                var box = new Box(length, width, height);
                Console.WriteLine(box.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
