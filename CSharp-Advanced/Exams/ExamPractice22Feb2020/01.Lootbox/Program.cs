using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        { 
            var firstLootBox = new Queue<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray());

            var secondLootBox = new Stack<int>(Console
                .ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray());

            var claimedItems = 0;

            while (firstLootBox.Any() && secondLootBox.Any())
            {
                var firstBoxItem = firstLootBox.Peek();
                var secondBoxItem = secondLootBox.Peek();
                var sum = firstBoxItem + secondBoxItem;

                if (sum % 2 == 0)
                {
                    claimedItems += sum;
                    firstLootBox.Dequeue();
                    secondLootBox.Pop();
                }
                else
                {
                    firstLootBox.Enqueue(secondBoxItem);
                    secondLootBox.Pop();
                }
            }

            Console.WriteLine(!firstLootBox.Any() 
                ? "First lootbox is empty" 
                : "Second lootbox is empty");

            Console.WriteLine(claimedItems >= 100
                ? $"Your loot was epic! Value: {claimedItems}"
                : $"Your loot was poor... Value: {claimedItems}");
        }
    }
}
