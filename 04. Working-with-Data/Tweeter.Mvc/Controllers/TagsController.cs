using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using Tweeter.Data.Models;
using Tweeter.Data.Repositories;
using Tweeter.Mvc.Models;

namespace Tweeter.Mvc.Controllers
{
    public class TagsController : BaseController
    {
        IRepository<Tweet> tweets = new GenericRepository<Tweet>();
        IRepository<Tag> tags = new GenericRepository<Tag>();

        // GET: Tags
        public ActionResult Index(string tagName)
        {
            if (tagName == null)
            {
                var myTweets = tweets.All()
                    .ProjectTo<TweeterPersonalViewModel>()
                    .ToList();

                return View(myTweets);
            }
            else
            {
                var selectedTag = tags.All()
                    .Where(t => t.Title == tagName)
                    .FirstOrDefault();

                if (selectedTag != null)
                {
                    return View(selectedTag.Tweets.AsQueryable().ProjectTo<TweeterPersonalViewModel>().ToList());
                }

                return View(new List<TweeterPersonalViewModel>());
            }
        }
    }
}