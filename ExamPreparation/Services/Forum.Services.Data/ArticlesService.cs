namespace Forum.Services.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Forum.Constants;
    using Forum.Data.Models;
    using Forum.Data.Repositories;
    using Forum.Services.Data.Contracts;

    public class ArticlesService : IArticlesService
    {        
        private readonly IRepository<Article> articles;
        private readonly IRepository<Category> categories;
        private readonly IRepository<Tag> tags;

        public ArticlesService(IRepository<Article> articles, IRepository<Category> categories, IRepository<Tag> tags)
        {
            this.articles = articles;
            this.categories = categories;
            this.tags = tags;
        }

        public IQueryable<Article> GetArticles(int page = 0, string category = null)
        {
            IQueryable<Article> result;

            if (category == null)
            {
                result =
                    this.articles.All()
                        .OrderBy(a => a.DateTime)
                        .Skip(page * Constants.ForumPageSize)
                        .Take(Constants.ForumPageSize);
            }
            else
            {
                result =
                    this.articles.All()
                        .OrderBy(a => a.DateTime)
                        .Where(c => c.Category.Name == category)
                        .Skip(page * Constants.ForumPageSize)
                        .Take(Constants.ForumPageSize);
            }

            return result;
        }

        public IQueryable<Article> GetArticleById(int id)
        {
            var result = this.articles.All().Where(c => c.Id == id);

            return result;
        }

        public Article AddArticle(string title, string content, string category, string[] tags)
        {                       
            var newArticle = new Article
                                 {
                                     Title = title,
                                     Content = content,
                                     DateTime = DateTime.UtcNow,
                                 };

            var categoryDb = this.categories.All().FirstOrDefault(c => c.Name == category); ;

            //if (categoryDb == null)
            //{
            //    newArticle.Category = new Category() { Name = category};
            //}
            //else
            //{
            //    newArticle.CategoryId = categoryDb.Id;
            //}

            //foreach (var tag in tags)
            //{
            //    var tagDb = this.tags.All().FirstOrDefault(t => t.Name == tag);

            //    newArticle.Tags.Add(tagDb ?? new Tag() { Name = tag, });
            //}

            this.articles.Add(newArticle);
            this.articles.SaveChanges();

            return newArticle;
        }
    }
}
