using System;
using System.Linq;

namespace CustomDataStructers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var stack = new CustomStack<int>();

            for (var i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            stack.ForEach(x => Console.WriteLine(x));

            Console.WriteLine(string.Join(" ", stack.Where(x => x % 2 == 0)));
        }
    }
}
