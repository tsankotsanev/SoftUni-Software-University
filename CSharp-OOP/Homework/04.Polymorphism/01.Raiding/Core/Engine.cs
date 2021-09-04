using System;
using System.Collections.Generic;
using _01.Raiding.Core.Contacts;
using _01.Raiding.Enumerator;
using _01.Raiding.Models;

namespace _01.Raiding.Core
{
    public class Engine : IEngine
    {

        public void Run()
        {
            var heroes = new List<BaseHero>();

            var countOfHeroes = int.Parse(Console.ReadLine());

            for (var i = 0; i < countOfHeroes; i++)
            {
                var heroName = Console.ReadLine();
                var heroType = Console.ReadLine();

                try
                {
                    BaseHero hero = null;

                    if (SearchHero(heroType) == Heroes.Druid)
                    {
                        heroes.Add(new Druid(heroName));
                    }
                    else if (SearchHero(heroType) == Heroes.Paladin)
                    {
                        heroes.Add(new Paladin(heroName));
                    }
                    else if (SearchHero(heroType) == Heroes.Rogue)
                    {
                        heroes.Add(new Rogue(heroName));
                    }
                    else if (SearchHero(heroType) == Heroes.Warrior)
                    {
                        heroes.Add(new Warrior(heroName));
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                    i--;
                }
            }

            var powerOfBoss = int.Parse(Console.ReadLine());

            var totalPowerOfHeroes = 0;
            totalPowerOfHeroes = PrintHeroes(heroes, totalPowerOfHeroes);

            var result = totalPowerOfHeroes >= powerOfBoss ? "Victory!" : "Defeat...";
            Console.WriteLine(result);

        }

        private static int PrintHeroes(List<BaseHero> heroes, int totalPowerOfHeroes)
        {
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.CastAbility());
                totalPowerOfHeroes += hero.Power;
            }

            return totalPowerOfHeroes;
        }

        private static Heroes SearchHero(string heroType)
        {
            Heroes hero;

            if (!Enum.TryParse<Heroes>(heroType, out hero))
            {
                throw new ArgumentException("Invalid hero!");
            }
            return hero;
        }
    }
}
