﻿namespace _01.Raiding.Models
{
    public class Paladin : BaseHero
    {
        private const int POWER = 100;
        public Paladin(string name)
            : base(name)
        {

        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} healed for {Power}";
        }
    }
}
