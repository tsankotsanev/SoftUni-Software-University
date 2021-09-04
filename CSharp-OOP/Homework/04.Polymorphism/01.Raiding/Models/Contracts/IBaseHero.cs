namespace _01.Raiding.Models.Contracts
{
    interface IBaseHero
    {
        public string Name { get; }
        public int Power { get;  }
        string CastAbility();
    }
}
