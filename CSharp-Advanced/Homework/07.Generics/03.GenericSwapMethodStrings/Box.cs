using System.Collections.Generic;
using System.Text;

namespace _03.GenericSwapMethodStrings
{
    class Box<T>
    {
        public Box()
        {
            Value = new List<T>();
        }

        public List<T> Value { get; set; }

        public void Swap(int a, int b)
        {
            (Value[a], Value[b]) = (Value[b], Value[a]);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var input in Value)
            {
                sb.AppendLine($"{input.GetType().FullName}: {input}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
