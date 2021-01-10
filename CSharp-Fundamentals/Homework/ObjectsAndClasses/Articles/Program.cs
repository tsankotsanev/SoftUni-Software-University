using System;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            var articles = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            var title = articles[0];
            var content = articles[1];
            var author = articles[2];

            var article = new Article(title, content, author);

            var n = int.Parse(Console.ReadLine());

            for (var i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var command = tokens[0];
                var argument = tokens[1];

                switch (command)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;

                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }

            Console.WriteLine(article.ToString());
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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }
}