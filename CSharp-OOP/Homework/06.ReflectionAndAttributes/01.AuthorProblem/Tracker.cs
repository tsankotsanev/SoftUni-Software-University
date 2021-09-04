using System;
using System.Linq;
using System.Reflection;

namespace _01.AuthorProblem
{
    class Tracker
    {
        public void PrintMethodsByAuthor() 
        {
            var type = typeof(StartUp);
            var methods = type.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static);
            foreach (var item in methods)
            {
                if (item.CustomAttributes.Any(n => n.AttributeType == typeof(AuthorAttribute)))
                {
                    var attributes = item.GetCustomAttributes(false);
                    foreach (AuthorAttribute attr in attributes)
                    {
                        Console.WriteLine($"{item.Name} {attr.Name}");
                    }
                }
            }
        }
    }
}
