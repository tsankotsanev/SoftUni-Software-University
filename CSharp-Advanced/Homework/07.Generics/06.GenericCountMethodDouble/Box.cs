using System;
using System.Collections.Generic;
using System.Text;

namespace _06.GenericCountMethodDouble
{
    public class Box<T>
        where T : IComparable
    {
        public List<T> StoreElement { get; set; }
        public Box()
        {
            StoreElement = new List<T>();
        }

        public int GreaterThan(T compareElement)
        {
            var count = 0;
            foreach (var element in StoreElement)
            {
                if (element.CompareTo(compareElement) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
