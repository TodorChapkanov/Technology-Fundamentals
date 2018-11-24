namespace _03_Articles2._0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }



    public class Program
    {
        public static void Main()
        {
            var articleCount = int.Parse(Console.ReadLine());
            var listOfArticles = new List<Article>();
            for (int i = 0; i < articleCount; i++)
            {
                var input = Console.ReadLine().Split(", ");

                var title = input[0];
                var content = input[1];
                var author = input[2];

                Article newArticle = new Article()
                {
                    Title = title,
                    Content = content,
                    Author = author
                };
                listOfArticles.Add(newArticle);
            }
            var sortedBy = Console.ReadLine();
            if (sortedBy == "title")
            {
                foreach (var article in listOfArticles.OrderBy(x => x.Title))
                {
                    Console.WriteLine(article);
                }
            }
            else if (sortedBy == "content")
            {
                foreach (var article in listOfArticles.OrderBy(x => x.Content))
                {
                    Console.WriteLine(article);
                }
            }
            else
            {
                foreach (var article in listOfArticles.OrderBy(x => x.Author))
                {
                    Console.WriteLine(article);
                }
            }


        }
    }
}
