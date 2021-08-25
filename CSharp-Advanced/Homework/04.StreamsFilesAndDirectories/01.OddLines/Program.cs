using System.IO;

namespace _01.OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("..//..//..//input.txt");
            using (reader)
            {
                var counter = 0;
                var line = reader.ReadLine();

                using (var writer = new StreamWriter("..//..//..//Output.txt"))
                {
                    while (line != null)
                    {
                        if (counter % 2 == 1)
                        {
                            writer.WriteLine(line);
                        }
                        counter++;
                        line = reader.ReadLine();
                    }
                }
            }
        }

    }
}