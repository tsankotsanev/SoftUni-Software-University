using System.Collections.Generic;
using System.Text;

namespace _03.PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name)
        {
            Name = name;
            Badges = 0;
            Pokemon = new List<Pokemon>();
        }

        public string Name { get; set; }

        public int Badges { get; set; }

        public List<Pokemon> Pokemon { get; set; }

        public void Give()
        {
            Badges++;
        }

        public override string ToString()
        {
            return $"{Name} {Badges} {Pokemon.Count}";
        }
    }
}
