using System;
using System.Text;

namespace _01.Animals
{
    public abstract class Animal
    {
        private string gender;
        private int age;

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
        public string Name { get; }

        public int Age
        {
            get => age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }
        public string Gender
        {
            get => gender;
            private set
            {
                if (value != "Male" && value != "Female")
                {
                    throw new ArgumentException("Invalid input!");
                }
                gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"{GetType().Name}");
            sb.AppendLine($"{Name} {Age} {Gender}");
            sb.AppendLine($"{ProduceSound()}");

            return sb.ToString().TrimEnd();
        }

    }
}
