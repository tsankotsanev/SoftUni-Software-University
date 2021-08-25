using System;
using System.Text;

namespace _03.Person
{
    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        private string name;

        private int age;

        public string Name
        {
            get => name;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }
        public virtual int Age
        {
            get => age;
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid Age");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.Append($"Name: {Name}, Age: {Age}");
            return sb.ToString();
        }
    }
}
