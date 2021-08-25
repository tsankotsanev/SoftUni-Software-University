namespace _04.RawData
{
    public class Tire
    { 
        public Tire(double pressure, int year)
        {
            Year = year;
            Pressure = pressure;
        }

        public int Year { get; set; }

        public double Pressure { get; set; }
    }
}
