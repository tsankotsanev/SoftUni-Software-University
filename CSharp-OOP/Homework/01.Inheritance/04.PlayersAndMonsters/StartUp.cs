using System;

namespace _04.PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var hero  =  new Hero("Blade", 2);
            var elf = new Elf("Bandy", 13);

            Console.WriteLine(elf);
            Console.WriteLine(hero.ToString());
        }
    }
}