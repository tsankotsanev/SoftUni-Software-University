using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var skill = Console.ReadLine();

            var command = "";

            while ((command = Console.ReadLine()) != "For Azeroth")
            {
                var splitCommand = command.Split(" ",
                    StringSplitOptions.RemoveEmptyEntries);
                var action = splitCommand[0];

                switch (action)
                {
                    case "GladiatorStance":
                        skill = skill.ToUpper();

                        Console.WriteLine(skill);
                        break;
                    case "DefensiveStance":
                        skill = skill.ToLower();

                        Console.WriteLine(skill);
                        break;
                    case "Dispel":
                        var index = int.Parse(splitCommand[1]);
                        var letter = splitCommand[2];

                        if (index < 0 || index > skill.Length - 1)
                        {
                            Console.WriteLine("Dispel too weak.");
                        }
                        else
                        {
                            var letterToReplace = skill[index];
                            var indexOfLetterToReplace = skill.IndexOf(letterToReplace);

                            skill = skill.Remove(indexOfLetterToReplace, 1);
                            skill = skill.Insert(indexOfLetterToReplace, letter);

                            Console.WriteLine("Success!");
                        }
                        break;
                    case "Target":
                        var secondCommand = splitCommand[1];

                        if (secondCommand == "Change")
                        {
                            var substring = splitCommand[2];
                            var secondSubstring = splitCommand[3];

                            skill = skill.Replace(substring, secondSubstring);
                            Console.WriteLine(skill);
                        }
                        else if (secondCommand == "Remove")
                        {
                            var substringToRemove = splitCommand[2];

                            skill = skill.Replace(substringToRemove, "");

                            Console.WriteLine(skill);
                        }
                        else
                        {
                            goto default;
                        }
                        break;
                    default:
                        Console.WriteLine("Command doesn't exist!");
                        break;
                }
            }
        }
    }
}
