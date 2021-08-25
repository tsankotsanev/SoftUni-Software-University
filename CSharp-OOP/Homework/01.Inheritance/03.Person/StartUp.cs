using System;

namespace _03.Person
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var name = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());

            var person = age <= 15 ? new Child(name, age) : new Person(name, age);

            Console.WriteLine(person);
        }
    }
}