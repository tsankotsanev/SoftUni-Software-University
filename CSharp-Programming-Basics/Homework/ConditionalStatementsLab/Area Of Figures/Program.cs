using System;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();

            if (figureType == "square")
            {
                var side = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", side * side);
            }
            else if (figureType == "rectangle")
            {
                var firstSideLength = double.Parse(Console.ReadLine());
                var secondSideLength = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", firstSideLength * secondSideLength);
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", Math.PI * (radius * radius));
            }
            else if (figureType == "triangle")
            {
                var firstSideLength = double.Parse(Console.ReadLine());
                var secondSideLength = double.Parse(Console.ReadLine());

                Console.WriteLine("{0:F3}", firstSideLength * secondSideLength / 2);
            }
        }
    }
}
