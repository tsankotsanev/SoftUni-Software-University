using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var articles = new List<Article>();

            for (var i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var title = tokens[0];
                var content = tokens[1];
                var author = tokens[2];

                var article = new Article(title, content, author);

                articles.Add(article);
            }

            var input = Console.ReadLine();

            switch (input)
            {
                case "title":
                    {
                        foreach (var article in articles.OrderBy(x => x.Title))
                        {
                            Console.WriteLine(article.ToString());
                        }

                        break;
                    }
                case "content":
                    {
                        foreach (var article in articles.OrderBy(x => x.Content))
                        {
                            Console.WriteLine(article.ToString());
                        }

                        break;
                    }
                case "author":
                    {
                        foreach (var article in articles.OrderBy(x => x.Author))
                        {
                            Console.WriteLine(article.ToString());
                        }

                        break;
                    }
            }
        }
    }
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}