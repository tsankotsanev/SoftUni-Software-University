namespace TheRace
{
    using System;

    public class UnitDriver
    {
        private string name;

        public UnitDriver(string name, UnitCar car)
        {
            Name = name;
            Car = car;
        }

        public string Name
        {
            get => name;
            private set => name = value ?? throw new ArgumentNullException(nameof(Name), "Name cannot be null!");
        }

        public UnitCar Car { get; }
    }
}