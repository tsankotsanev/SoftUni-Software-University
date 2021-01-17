using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            var openBrackets = new Stack<char>();
            var brackets = Console.ReadLine();
            var closingBracketsCount = 0;
            var openBracketsCount = 0;
            var isBalanced = true;

            foreach (var bracket in brackets)
            {
                if (bracket == '(' || bracket == '[' || bracket == '{')
                {
                    openBrackets.Push(bracket);
                    openBracketsCount++;
                }
                else
                {
                    closingBracketsCount++;

                    if (closingBracketsCount <= openBracketsCount)
                    {
                        var roundBrackets = bracket == ')' && openBrackets.Pop() == '(';
                        var boxBrackets = bracket == ']' && openBrackets.Pop() == '[';
                        var curlyBrackets = bracket == '}' && openBrackets.Pop() == '{';

                        if (!roundBrackets && !boxBrackets && !curlyBrackets)
                        {
                            isBalanced = false;
                        }
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            Console.WriteLine(isBalanced ? "YES" : "NO");
        }
    }
}