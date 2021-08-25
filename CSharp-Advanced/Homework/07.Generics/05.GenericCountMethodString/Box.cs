using System;
using System.Collections.Generic;
using System.Text;

namespace _05.GenericCountMethodString
{
    public class Box<T> 
         where T : IComparable
    {
        public List<T> StoreElement { get; set; }
        public Box()
        {
            StoreElement = new List<T>();
        }

        public int GreaterThan(string compareElement)
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
