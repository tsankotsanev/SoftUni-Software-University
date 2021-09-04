namespace TheRace
{
    public class UnitCar
    {
        public UnitCar(string model, int horsePower, double cubicCentimeters)
        {
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;
        }

        public string Model { get; }

        public int HorsePower { get; }

        public double CubicCentimeters { get; }
    }
}