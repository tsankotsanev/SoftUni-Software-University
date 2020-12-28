using System;
using System.Collections.Generic;
using System.Linq;

namespace HeroesOfCodeAndLogicVII
{
    class HeroesOfCodeAndLogicVII
    {
        static void Main(string[] args)
        {
            var heroes = new Dictionary<string, Dictionary<string, int>>();

            var heroesCount = int.Parse(Console.ReadLine());

            for (var i = 0; i < heroesCount; i++)
            {
                var heroesInfo = Console.ReadLine()
                    .Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                var heroName = heroesInfo[0];
                var heroHp = int.Parse(heroesInfo[1]);
                var heroMp = int.Parse(heroesInfo[2]);
                heroes.Add(heroName,
                    new Dictionary<string, int>
                    {
                        {"heroHp", heroHp},
                        {"heroMp", heroMp}
                    });

            }

            var command = "";

            while ((command = Console.ReadLine()) != "End")
            {
                var splitCommand = command.Split(" - ",
                    StringSplitOptions.RemoveEmptyEntries);
                var action = splitCommand[0];
                var hero = splitCommand[1];

                switch (action)
                {
                    case "CastSpell":
                        var mpRequired = int.Parse(splitCommand[2]);
                        var spellName = splitCommand[3];

                        if (heroes[hero]["heroMp"] >= mpRequired)
                        {
                            heroes[hero]["heroMp"] -= mpRequired;

                            Console.WriteLine($"{hero} has successfully cast {spellName} and now has {heroes[hero]["heroMp"]} MP!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
                        }
                        break;
                    case "TakeDamage":
                        var damage = int.Parse(splitCommand[2]);
                        var attacker = splitCommand[3];
                        heroes[hero]["heroHp"] -= damage;

                        if (heroes[hero]["heroHp"] > 0)
                        {
                            Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {heroes[hero]["heroHp"]} HP left!");
                        }
                        else
                        {
                            Console.WriteLine($"{hero} has been killed by {attacker}!");
                            heroes.Remove(hero);
                        }
                        break;
                    case "Recharge":
                        var amountMp = int.Parse(splitCommand[2]);
                        if (heroes[hero]["heroMp"] + amountMp > 200)
                        {
                            var oldMp = heroes[hero]["heroMp"];
                            heroes[hero]["heroMp"] = 200;
                            var healedAmount = 200 - oldMp;

                            Console.WriteLine($"{hero} recharged for {healedAmount} MP!");
                        }
                        else
                        {
                            heroes[hero]["heroMp"] += amountMp;
                            Console.WriteLine($"{hero} recharged for {amountMp} MP!");
                        }
                        break;
                    case "Heal":
                        var amountHp = int.Parse(splitCommand[2]);

                        if (heroes[hero]["heroHp"] + amountHp > 100)
                        {
                            var oldHp = heroes[hero]["heroHp"];
                            heroes[hero]["heroHp"] = 100;
                            var healedAmount = 100 - oldHp;

                            Console.WriteLine($"{hero} healed for {healedAmount} HP!");
                        }
                        else
                        {
                            heroes[hero]["heroHp"] += amountHp;
                            Console.WriteLine($"{hero} healed for {amountHp} HP!");
                        }
                        break;
                }
            }

            var sortedHeroes = heroes
                .OrderByDescending(h => h.Value["heroHp"])
                .ThenBy(h => h.Key);

            foreach (var hero in sortedHeroes)
            {
                Console.WriteLine(string.Join(Environment.NewLine,
                    hero.Key,
                    $"HP: {hero.Value["heroHp"]}",
                    $"MP: {hero.Value["heroMp"]}"));
            }
        }
    }
}
