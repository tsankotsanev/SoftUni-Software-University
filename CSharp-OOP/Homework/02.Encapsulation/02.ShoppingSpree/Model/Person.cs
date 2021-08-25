using System;
using System.Collections.Generic;
using _02.ShoppingSpree.Common;
using static System.String;

namespace _02.ShoppingSpree.Model
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;
        private Person()
        {
            bag = new List<Product>();
        }
        public Person(string name, decimal money):this()
        {
            Name = name;
            Money = money;
        }

        public IReadOnlyCollection<Product> Bag => bag.AsReadOnly();
        public string Name
        {
            get => name;
            private set
            {
                if (IsNullOrWhiteSpace(value) || IsNullOrEmpty(value))
                {
                    throw new
                    ArgumentException(Format(GlobalConstants.InvalidInputNameExceptionMessage, nameof(Name)));
                }
                name = value;
            }
        }
        public decimal Money
        {
            get => money;
            private set
            {
                if (value < GlobalConstants.CostMinValue)
                {
                    throw new
                        ArgumentException(Format(GlobalConstants.InvalidMoneyExceptionMessage, nameof(Money)));
                }
                money = value;
            }
        }
   
        public void BuyProduct(Product product)
        {
            if (Money < product.Cost)
            {
                throw new
                InvalidOperationException(Format(GlobalConstants.InsufficientMoneyExceptionMessage, Name, product.Name));
            }
            Money -= product.Cost;
            bag.Add(product);
        }
        public override string ToString()
        {
            var productsOutput = Bag.Count > 0 ? Join(", ", Bag) : "Nothing bought";

            return $"{Name} - {productsOutput}";
        }
    }
}
