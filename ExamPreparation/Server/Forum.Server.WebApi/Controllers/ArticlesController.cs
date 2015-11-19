namespace Forum.Server.WebApi.Controllers
{
    using System.Linq;
    using System.Web.Http;

    using AutoMapper.QueryableExtensions;

    using Forum.Data.Models;
    using Forum.Server.WebApi.Infrastructure.Validation;
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
                    .GetArticles(page - 1)
                    .ProjectTo<ArticleResponseModel>()
                    .ToList();

            return this.Ok(articles);
        }

        [Authorize]
        public IHttpActionResult Get(string category)
        {
            var articles = this.articleService
                    .GetArticles(1, category)
                    .ProjectTo<ArticleResponseModel>()
                    .ToList();

            return this.Ok(articles);
        }

        [Authorize]
        public IHttpActionResult Get(int page, string category)
        {
            var articles = this.articleService
                    .GetArticles(page - 1, category)
                    .ProjectTo<ArticleResponseModel>()
                    .ToList();

            return this.Ok(articles);
        }

        [Authorize]
        public IHttpActionResult Post(ArticleRequestModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var newArticle = this.articleService.AddArticle(model.Title, model.Content, model.Category, model.Tags);
            var result =
                this.articleService.GetArticleById(newArticle.Id).ProjectTo<ArticleResponseModel>().FirstOrDefault();

            return this.Ok(result);
        }
    }
}
