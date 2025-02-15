﻿using System;

namespace _03.Person
{
    class Child : Person
    {
        public Child(string name, int age)
           : base(name, age)
        {

        }
        public override int Age
        {
            get => base.Age;
            protected set
            {
                if (value>15)
                {
                    throw new ArgumentException("Child age cannot be more than 15");
                }
                base.Age = value;
            }
        }
    }
}
