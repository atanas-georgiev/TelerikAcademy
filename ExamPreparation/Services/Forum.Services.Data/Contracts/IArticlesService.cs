namespace Forum.Services.Data.Contracts
{
    using System.Linq;

    using Forum.Data.Models;

    public interface IArticlesService
    {
        IQueryable<Article> GetArticles(int page = 0, string category = null);

        Article AddArticle(string title, string content, string category, string[] tags);

        IQueryable<Article> GetArticleById(int id);
    }
}
