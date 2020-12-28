using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogsCount = int.Parse(Console.ReadLine());
            int otherTheAnimals = int.Parse(Console.ReadLine());
            double dogsFoodPrice = 2.50;
            double otherAnimalsFoodPrice = 4;
            double totalDogsFood = dogsCount * dogsFoodPrice;
            double totalOtherAnimalsFood = otherTheAnimals * otherAnimalsFoodPrice;

            double finalCost = totalDogsFood + totalOtherAnimalsFood;

            Console.WriteLine($"{finalCost} lv.");
        }
    }
}
