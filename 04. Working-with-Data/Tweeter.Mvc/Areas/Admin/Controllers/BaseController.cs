using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Tweeter.Data.Models;
using Tweeter.Data.Repositories;
using Tweeter.Mvc.Areas.Admin.Models;

namespace Tweeter.Mvc.Areas.Admin.Controllers
{
    public abstract class BaseController : Controller
    {
        IRepository<Tweet> tweets = new GenericRepository<Tweet>();

        protected abstract T GetById<T>(object id) where T : class;

        [HttpPost]
        public ActionResult Read([DataSourceRequest]DataSourceRequest request)
        {
            var ads =
                this.tweets.All()
                .ToDataSourceResult(request);

            return this.Json(ads);
        }

        [NonAction]
        protected virtual T Create<T>(object model) where T : Tweet
        {
            if (model != null && ModelState.IsValid)
            {
                var dbModel = Mapper.Map<T>(model);
                this.tweets.Add(dbModel);
                this.tweets.SaveChanges();
                return dbModel;
            }

            return null;
        }

        [NonAction]
        protected virtual void Update<TModel, TViewModel>(TViewModel model, object id)
            where TModel : Tweet
            where TViewModel : TweetAdminViewModel
        {
            if (model != null && ModelState.IsValid)
            {
                var intId = (int)id;
                var dbModel = this.tweets.GetById(intId);
                Mapper.Map<TViewModel, Tweet>(model, dbModel);
                this.tweets.Update(dbModel);
                this.tweets.SaveChanges();
            }
        }

        protected JsonResult GridOperation<T>(T model, [DataSourceRequest]DataSourceRequest request)
        {
            return Json(new[] { model }.ToDataSourceResult(request, ModelState));
        }
    }

}