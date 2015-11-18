namespace Forum.Server.WebApi.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;

    using Forum.Server.WebApi.Models.Articles;
    using Forum.Services.Data.Contracts;

    public class ArticlesController : ApiController
    {
        private readonly IArticlesService articleService;

        public ArticlesController(IArticlesService articleService)
        {
            this.articleService = articleService;
        }

        public IHttpActionResult Get(int page = 1)
        {
            var articles = this.articleService
                    .GetPublicArticles()
                    .ProjectTo<ArticleResponseModel>()
                    .ToList();

            return this.Ok(articles);
        }
    }
}
