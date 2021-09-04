namespace _02.Vehicles.Models
{
    public class Car : Vehicle
    {
        private const double FUEL_CONSUMPTION_MODIFIER = 0.9;
        public Car(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
            FuelConsumption += FUEL_CONSUMPTION_MODIFIER;
        }

        public override bool Hole => false;
    }
}
