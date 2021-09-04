using System;
using System.Collections.Generic;
using System.Linq;
using _07.MilitaryElite.Contracts;
using _07.MilitaryElite.Core.Contracts;
using _07.MilitaryElite.Exceptions;
using _07.MilitaryElite.IO.Contracts;
using _07.MilitaryElite.Models;

namespace _07.MilitaryElite.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;

        private ICollection<ISoldier> soldiers;
        private Engine()
        {
            soldiers = new List<ISoldier>();
        }
        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            var command = string.Empty;

            while ((command = reader.ReadLine()) != "End")
            {

                var cmndArgs = command
                             .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                             .ToArray();

                var soldierType = cmndArgs[0];
                var id = int.Parse(cmndArgs[1]);
                var firstName = cmndArgs[2];
                var lastName = cmndArgs[3];

                ISoldier soldier = null;

                if (soldierType == "Private")
                {
                    soldier = AddPrivate(cmndArgs, id, firstName, lastName);
                }
                else if (soldierType == "LieutenantGeneral")
                {
                    soldier = AddLieutenantGeneral(cmndArgs, id, firstName, lastName);
                }
                else if (soldierType == "Engineer")
                {
                    var salary = decimal.Parse(cmndArgs[4]);

                    var corps = cmndArgs[5];

                    try
                    {
                        soldier = CreateEngineer(cmndArgs, id, firstName, lastName, salary, corps);
                    }
                    catch (InvalidCorpsExeption ice)
                    {
                        continue;
                    }
                }
                else if (soldierType == "Commando")
                {
                    var salary = decimal.Parse(cmndArgs[4]);
                    var corps = cmndArgs[5];

                    try
                    {
                        var commando = GetCommando(cmndArgs, id, firstName, lastName, salary, corps);

                        soldier = commando;
                    }
                    catch (InvalidCorpsExeption ice)
                    {
                        continue;
                    }
                }
                else if (soldierType == "Spy")
                {
                    var codeNumber = int.Parse(cmndArgs[4]);

                    soldier = new Spy(id, firstName, lastName, codeNumber);
                }
                if (soldier != null)
                {
                    soldiers.Add(soldier);

                }
            }

            foreach (var soldier in soldiers)
            {
                writer.WriteLine(soldier.ToString());
            }
        }

        private static ISoldier CreateEngineer(string[] cmndArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ISoldier soldier;
            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);

            var repairArgs = cmndArgs
                                .Skip(6)
                                .ToArray();

            for (var i = 0; i < repairArgs.Length; i += 2)
            {
                var partName = repairArgs[i];
                var hoursWorked = int.Parse(repairArgs[i + 1]);

                IRepair repair = new Repair(partName, hoursWorked);
            }
            soldier = engineer;
            return soldier;
        }

        private static ICommando GetCommando(string[] cmndArgs, int id, string firstName, string lastName, decimal salary, string corps)
        {
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            var misiionArgs = cmndArgs
                                 .Skip(6)
                                 .ToArray();

            for (var i = 0; i < misiionArgs.Length; i += 2)
            {
                try
                {
                    var missionCodeName = misiionArgs[i];
                    var missionState = misiionArgs[i + 1];

                    IMission misiion = new Mission(missionCodeName, missionState);

                    commando.AddMission(misiion);
                }
                catch (InvalidMissionStateExeption imse)
                {
                }
            }

            return commando;
        }


        private ISoldier AddLieutenantGeneral(string[] cmndArgs, int id, string firtName, string lastName)
        {
            ISoldier soldier;
            var salary = decimal.Parse(cmndArgs[4]);
            ILieutenantGeneral general = new LieutenantGeneral(id, firtName, lastName, salary);

            foreach (var pID in cmndArgs.Skip(5))
            {
                var privateToAdd =
                    soldiers.First(x => x.Id == int.Parse(pID));

                general.AddPrivate(privateToAdd);
            }

            soldier = general;
            return soldier;
        }

        private static ISoldier AddPrivate(string[] cmndArgs, int id, string firtName, string lastName)
        {
            ISoldier soldier;
            var salary = decimal.Parse(cmndArgs[4]);
            soldier = new Private(id, firtName, lastName, salary);
            return soldier;
        }
    }
}
