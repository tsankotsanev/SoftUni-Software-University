
namespace _01.CarSalesman
{
    public class Engine
    {
        private string engineModel;
        private int power;
        private int displacement;
        private string efficiency;
      

        public Engine(string engineModel, int power, int displacement, string efficiency)
        {
            EngineModel = engineModel;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }

        public string EngineModel { get; set; }

        public int Power { get; set; }

        public int Displacement { get; set; }

        public string Efficiency { get; set; }
    }
}
