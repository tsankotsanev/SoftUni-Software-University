using System;
using System.Collections.Generic;
using System.Linq;
using _004.BorderControl.Contract;
using _004.BorderControl.Model;

namespace _004.BorderControl.Core
{
    public class Engine
    {
        public void Run()
        {
            var residents = new List<IIDValidatorable>();
            var command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                var data = command
                               .Split(" ")
                               .ToArray();

                var name = data[0];

                if (data.Length == 3)
                {
                    var age = int.Parse(data[1]);
                    var ID = data[2];
                    IIDValidatorable citizen = new Ctizen(name, age, ID);
                    residents.Add(citizen);
                }
                else
                {
                    var ID = data[1];
                    IIDValidatorable robbot = new Robot(name, ID);
                    residents.Add(robbot);
                }

            }

            var lastDigit = Console.ReadLine();
            residents = residents.Where(x => x.ID.EndsWith(lastDigit)).ToList();
            residents.ForEach(Console.WriteLine);
        }
    }
}
