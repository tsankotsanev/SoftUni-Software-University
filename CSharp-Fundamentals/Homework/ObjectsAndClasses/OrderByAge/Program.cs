using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var people = new List<Human>();

            while (input != "End")
            {
                var tokens = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var name = tokens[0];
                var id = int.Parse(tokens[1]);
                var age = int.Parse(tokens[2]);

                people.Add(new Human(name, id, age));

                input = Console.ReadLine();
            }

            foreach (var human in people.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{human.Name} with ID: {human.Id} is {human.Age} years old.");
            }
        }
    }

    public class Human
    {
        public Human(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }
    }
}