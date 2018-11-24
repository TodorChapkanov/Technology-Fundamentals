namespace _02_Articles
{
    using System;

    public class Article
    {
        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }



        public void Edit (string content)
        {
            this.Content = content;
            
        }
        public void ChangeAuthor (string author)
        {
            this.Author = author;
            
        }
        public void Rename( string title)
        {
            Title = title;
            
        }
    }
    public class Articles
    {
        public static void Main()
        {
            var article = Console.ReadLine().Split(", ");
            var commandCount = int.Parse(Console.ReadLine());

            Article newArticle = new Article()
            {
                Title = article[0],
                Content = article[1],
                Author = article[2]
            };

            for (int i = 0; i < commandCount; i++)
            {
                var input = Console.ReadLine().Split(": ");
                if (input[0] == "Edit")
                {
                    newArticle.Edit(input[1]);
                }
                else if (input[0] == "ChangeAuthor")
                {
                    newArticle.ChangeAuthor(input[1]);
                }
                else
                {
                    newArticle.Rename(input[1]);
                }
            }

            Console.WriteLine(newArticle);

        }
    }
}
