namespace _02.NeedForSpeed
{
    public class Car : Vehicle
    {
        public new const double DefaultFuelConsumption = 3;

        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {
        }

        public override double FuelConsumption => DefaultFuelConsumption;
    }
}
