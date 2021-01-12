using System;

namespace Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            var personAge = int.Parse(Console.ReadLine());
            var personType = string.Empty;

            if (personAge >= 0 && personAge <= 2)
            {
                personType = "baby";
            }
            else if (personAge >= 3 && personAge <= 13)
            {
                personType = "child";
            }
            else if (personAge >= 14 && personAge <= 19)
            {
                personType = "teenager";
            }
            else if (personAge >= 20 && personAge <= 65)
            {
                personType = "adult";
            }
            else if (personAge >= 66)
            {
                personType = "elder";
            }
            Console.WriteLine(personType);
        }
    }
}
