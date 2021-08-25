using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ListyIterator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputInfo = Console
                      .ReadLine()
                      .Split(" ")
                      .Skip(1)
                      .ToList();

            var listyIterator =
                new ListyIterator<string>(inputInfo);

            var command = string.Empty;

            while ((command = Console.ReadLine()) != "END")
            {
                if (command == "Move")
                {
                    var boolean = listyIterator.Move();
                    Console.WriteLine(boolean);
                }
                else if (command == "HasNext")
                {
                    var boolean = listyIterator.HasNext();
                    Console.WriteLine(boolean);
                }
                else if (command == "Print")
                {
                    try
                    {
                        listyIterator.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                }
                else if (command== "PrintAll")
                {
                    foreach (var person in listyIterator)
                    {
                        Console.Write(person + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
