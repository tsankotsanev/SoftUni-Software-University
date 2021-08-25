using System.Collections.Generic;
using System.Text;

namespace _04.GenericSwapMethodInteger
{
    public class Box<T>
    {
        public Box()
        {
            Values = new List<T>();
        }

        public List<T> Values { get; set; }

        public void Swap(int a, int b)
        {
            (Values[a], Values[b]) = (Values[b], Values[a]);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var value in Values)
            {
                sb.AppendLine($"{value.GetType().FullName}: {value}");

            }
            return sb.ToString().TrimEnd();
        }

    }
}
