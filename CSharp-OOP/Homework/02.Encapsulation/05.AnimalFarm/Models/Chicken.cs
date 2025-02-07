﻿using System;
using _05.AnimalFarm.Common;

namespace _05.AnimalFarm.Models

{
    public class Chicken
    {
        private const int MinAge = 0;
        private const int MaxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get => name;

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                        (string.Format(GlobalConstants.InvalidName, Name));
                }
                name = value;
            }
        }

        public int Age
        {
            get => age;

            private set
            {
                if (value is < MinAge or > MaxAge)
                {
                    throw new InvalidOperationException
                        (string.Format(GlobalConstants.InvalidAge, nameof(Age), MinAge, MaxAge));
                }
                age = value;
            }
        }

        public double ProductPerDay => CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            switch (Age)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                    return 1.5;
                case 4:
                case 5:
                case 6:
                case 7:
                    return 2;
                case 8:
                case 9:
                case 10:
                case 11:
                    return 1;
                default:
                    return 0.75;
            }
        }
    }
}
