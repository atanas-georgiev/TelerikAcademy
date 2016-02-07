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
using Tweeter.Mvc.Models;

namespace Tweeter.Mvc.Areas.Admin.Controllers
{
    public class AdminController : BaseController
    {
        IRepository<Tweet> tweets = new GenericRepository<Tweet>();

        // GET: Admin/Tweets
        public ActionResult Index()
        {
            return View();
        }


        protected override T GetById<T>(object id)
        {
            return this.tweets.GetById((int)id) as T;
        }

        [HttpPost]
        public ActionResult Create([DataSourceRequest]DataSourceRequest request, TweetAdminViewModel model)
        {
            var dbModel = base.Create<Tweet>(model);
            if (dbModel != null) model.Id = dbModel.Id;
            return this.GridOperation(model, request);
        }
    }
}