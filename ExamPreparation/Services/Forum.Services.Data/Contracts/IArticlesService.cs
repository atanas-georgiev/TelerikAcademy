namespace Forum.Services.Data.Contracts
{
    using System.Linq;

    using Forum.Data.Models;

    public interface IArticlesService
    {
        IQueryable<Article> GetPublicArticles(int page = 0);
    }
}
