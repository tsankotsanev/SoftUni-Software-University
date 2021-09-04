namespace _01.Raiding.Models
{
    public class Rogue : BaseHero
    {
        private const int POWER = 80;
        public Rogue(string name) : base(name)
        {

        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
