namespace Forum.Services.Data
{
    using System.Linq;

    using Forum.Constants;
    using Forum.Data.Models;
    using Forum.Data.Repositories;
    using Forum.Services.Data.Contracts;

    public class ArticlesService : IArticlesService
    {        
        private readonly IRepository<Article> articles;        

        public ArticlesService(IRepository<Article> articles)
        {
            this.articles = articles;
        }

        public IQueryable<Article> GetPublicArticles(int page = 0)
        {
            var result = this.articles
                .All()
                .OrderBy(a => a.DateTime)
                .Skip(page * Constants.ForumPageSize)
                .Take(Constants.ForumPageSize);

            return result;
        }
    }
}
