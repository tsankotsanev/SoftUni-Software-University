namespace _05.Ferrari
{
    public class Ferrari : IDriveable
    {
        public Ferrari(string driver)
        {
            Driver = driver;
        }
        public string Model => "488-Spider";

        public string Driver { get; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string Push()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            return $"{Model}/{Brakes()}/{Push()}/{Driver}";
        }
    }
}
