namespace Task02_Articles
{
    using System;

    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var articles = new OrderedMultiDictionary<double, Article>(true);

            articles.Add(1.12, new Article("Article 1", "12234312213", "Microsoft"));
            articles.Add(12.12, new Article("Article 2", "21312321312", "Microsoft"));
            articles.Add(0.5, new Article("Article 3", "111111111", "Apple"));
            articles.Add(0.5, new Article("Article 4", "22222222222", "Microsoft"));
            articles.Add(100, new Article("Article 5", "12312312", "Apple"));

            // Find all articles in price range [1..20]
            var result = articles.Range(1, true, 20, true);

            foreach (var article in result)
            {
                Console.WriteLine(article);
            }
        }
    }
}
