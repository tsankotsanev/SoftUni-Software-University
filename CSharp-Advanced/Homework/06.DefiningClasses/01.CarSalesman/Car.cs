using System.Text;
namespace CarSalesman
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

            sb.AppendLine($"{this.Model}:");
            sb.AppendLine($"  {Engine.EngineModel}:");
            sb.AppendLine($"   Power: {Engine.Power}");
            sb.Append(this.Engine.Displacement == 0
                ? $"    " +
                $"Displacement: n/a" 
                : $"    Displacement: {this.Engine.Displacement}").AppendLine();
            sb.Append($"    Efficiency: {this.Engine.Efficiency}").AppendLine();
            sb.Append(this.Weight == 0 ? $"  Weight: n/a" : $"  Weight: {this.Weight}").AppendLine();
            sb.Append($"  Color: {this.Color}");

            return $"{sb}";
        }
    }
}
