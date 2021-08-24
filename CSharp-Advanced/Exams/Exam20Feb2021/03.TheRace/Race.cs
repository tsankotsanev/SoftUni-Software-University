using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheRace
{
    public class Race
    {
        private List<Racer> data = new List<Racer>();

        public Race(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int Count => data.Count;

        public void Add(Racer racer)
        {
            if (Count < Capacity)
            {
                data.Add(racer);
            }
        }

        public bool Remove(string name)
        {
            var currentRacer = data.FirstOrDefault(r => r.Name == name);
            if (currentRacer != null)
            {
                data.Remove(currentRacer);
                return true;
            }

            return false;
        }

        public Racer GetOldestRacer()
        {
            return data.OrderByDescending(r => r.Age).FirstOrDefault();
        }

        public Racer GetRacer(string name)
        {
            return data.FirstOrDefault(r => r.Name == name);
        }

        public Racer GetFastestRacer()
        { 
            return data.OrderByDescending(r => r.Car.Speed).FirstOrDefault();
        }

        public string Report()
        {
            var result = new StringBuilder();

            result.AppendLine($"Racers participating at {Name}:");
            foreach (var racer in data)
            {
                result.AppendLine(racer.ToString());
            }

            return result.ToString().TrimEnd();
        }
    }
}