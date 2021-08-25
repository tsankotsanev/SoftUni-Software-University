using System;
using _02.ShoppingSpree.Common;
using static System.String;

namespace _02.ShoppingSpree.Model
{
    public class Product
    {

        private string name;
        private decimal cost;

        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (IsNullOrWhiteSpace(value)||IsNullOrEmpty(value))
                {
                    throw new
                        ArgumentException(Format(GlobalConstants.InvalidInputNameExceptionMessage, nameof(Name)));
                }
                name = value;
            }
        }
        public decimal Cost
        {
            get => cost;

            private set
            {
                if (value < GlobalConstants.CostMinValue)
                {
                    throw new
                        ArgumentException(Format(GlobalConstants.InsufficientMoneyExceptionMessage, nameof(Cost)));
                }
                cost = value;
            }
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
