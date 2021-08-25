using System.Text;

namespace _01.CarSalesman
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;

        public Car(string model, Engine engine, int weight, string color)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Color = color;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public int Weight { get; set; }

        public string Color { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{Model}:");
            sb.AppendLine($"  {Engine.EngineModel}:");
            sb.AppendLine($"   Power: {Engine.Power}");
            sb.Append(Engine.Displacement == 0
                ? $"    " +
                $"Displacement: n/a" 
                : $"    Displacement: {Engine.Displacement}").AppendLine();
            sb.Append($"    Efficiency: {Engine.Efficiency}").AppendLine();
            sb.Append(Weight == 0 ? $"  Weight: n/a" : $"  Weight: {Weight}").AppendLine();
            sb.Append($"  Color: {Color}");

            return $"{sb}";
        }
    }
}
