﻿using _07.MilitaryElite.Contracts;

namespace _07.MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            PartName = partName;
            HoursWorked = hoursWorked;
        }

        public string PartName { get; }
        public int HoursWorked { get; }
        public override string ToString() =>
            $"  Part Name: {PartName} Hours Worked: {HoursWorked}";
    }
}
