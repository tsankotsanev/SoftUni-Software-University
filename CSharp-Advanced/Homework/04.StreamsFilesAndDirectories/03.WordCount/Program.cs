using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordAndFrequency = new Dictionary<string, int>();
            var words = File.ReadAllText("../../../Words.txt").Split();

            using (var reader = new StreamReader("../../../Input.txt"))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var wordsInCurrentLine = line.ToLower()
                        .Split(new[] { ' ', '.', ',', '-', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var word in words)
                    {
                        foreach (var item in wordsInCurrentLine)
                        {
                            if (word == item)
                            {
                                if (!wordAndFrequency.ContainsKey(item))
                                {
                                    wordAndFrequency.Add(item, 0);
                                }
                                wordAndFrequency[item]++;
                            }
                        }
                    }
                    line = reader.ReadLine();
                }
            }
            using (var writer = new StreamWriter("../../..Ooutput.txt"))
            {
                foreach (var item in wordAndFrequency.OrderByDescending(x => x.Value))
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}