using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tweeter.Data.Models;
using Tweeter.Data.Repositories;
using Tweeter.Mvc.Areas.Admin.Models;

namespace Tweeter.Mvc.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        IRepository<Tweet> tweets = new GenericRepository<Tweet>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult TweetAdminViewModels_Read([DataSourceRequest]DataSourceRequest request)
        {
            return Json(this.tweets.All().ProjectTo<TweetAdminViewModel>().ToDataSourceResult(request));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TweetAdminViewModels_Create([DataSourceRequest]DataSourceRequest request, TweetAdminViewModel tweet)
        {
            if (ModelState.IsValid)
            {
                var entity = new Tweet()
                {
                    Title = tweet.Title,
                    Content = tweet.Content
                };

                tweets.Add(entity);
                tweets.SaveChanges();
                tweet.Id = entity.Id;
            }

            return Json(new[] { tweet }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TweetAdminViewModels_Update([DataSourceRequest]DataSourceRequest request, TweetAdminViewModel tweet)
        {
            if (ModelState.IsValid)
            {
                var entity = new Tweet
                {
                    Id = tweet.Id,
                    Title = tweet.Title,
                    Content = tweet.Content
                };

                tweets.Update(entity);
                tweets.SaveChanges();
            }

            return Json(new[] { tweet }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult TweetAdminViewModels_Destroy([DataSourceRequest]DataSourceRequest request, TweetAdminViewModel tweet)
        {
            if (ModelState.IsValid)
            {
                var entity = new Tweet()
                {
                    Id = tweet.Id,
                    Title = tweet.Title,
                    Content = tweet.Content
                };

                tweets.Delete(entity);
                tweets.SaveChanges();
            }

            return Json(new[] { tweet }.ToDataSourceResult(request, ModelState));
        }

    }
}
