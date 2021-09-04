using System;
using _07.MilitaryElite.Contracts;
using _07.MilitaryElite.Enumerations;
using _07.MilitaryElite.Exceptions;

namespace _07.MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = TryParseCorps(corps);
        }

        public Corps Corps { get; }
        private Corps TryParseCorps(string corpsStr)
        {
            Corps corps;

            var parsed = Enum.TryParse(corpsStr, out corps);
            if (!parsed)
            {
                throw new InvalidCorpsExeption();
            }
            return corps;
        }
        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {Corps}";
        }
    }
}
