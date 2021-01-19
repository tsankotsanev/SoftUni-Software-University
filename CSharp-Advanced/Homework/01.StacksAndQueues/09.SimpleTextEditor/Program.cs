using System;
using System.Collections.Generic;
using System.Text;

namespace _09.SimpleTextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var sb = new StringBuilder();
            var stack = new Stack<string>();
            stack.Push(sb.ToString());

            for (var i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                var command = int.Parse(input[0]);

                switch (command)
                {
                    case 1:
                        sb.Append(input[1]);
                        stack.Push(sb.ToString());
                        break;
                    case 2:
                        var number = int.Parse(input[1]);
                        sb.Remove(sb.Length - number, number);
                        stack.Push(sb.ToString());
                        break;
                    case 3:
                        var index = int.Parse(input[1]);
                        Console.WriteLine(sb[index - 1]);
                        break;
                    case 4:
                        stack.Pop();
                        sb = new StringBuilder();
                        sb.Append(stack.Peek());
                        break;
                }
            }
        }
    }
}