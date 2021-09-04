
namespace _01.Raiding.Models
{
    public class Warrior : BaseHero
    {
        private const int POWER = 100;
        public Warrior(string name) : base(name)
        {

        }

        public override int Power => POWER;

        public override string CastAbility()
        {
            return $"{GetType().Name} - {Name} hit for {Power} damage";
        }
    }
}
