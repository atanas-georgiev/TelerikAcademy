using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tweeter.Data.Models;
using Tweeter.Data.Repositories;
using Tweeter.Mvc.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using WebGrease.Css.Extensions;

namespace Tweeter.Mvc.Controllers
{
    public class TweetsController : BaseController
    {
        IRepository<Tweet> tweets = new GenericRepository<Tweet>();
        IRepository<Tag> tags = new GenericRepository<Tag>();

        // GET: Tweets
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(TweetViewModel tweet)
        {
            if (ModelState.IsValid)
            {
                var newTweet = new Tweet()
                {
                    Content = tweet.Content,
                    CreatedDate = DateTime.UtcNow,
                    Title = tweet.Title,
                    UserId = this.UserProfile.Id
                };

                tweets.Add(newTweet);
                tweets.SaveChanges();

                var givenTags = tweet.Tags.Split(';');
                foreach (var tag in givenTags)
                {
                    var tagDb = this.tags.All().FirstOrDefault(t => t.Title == tag);
                    if (tagDb != null)
                    {
                        tagDb.Tweets.Add(newTweet);
                        this.tags.Update(tagDb);
                    }
                    else
                    {
                        var newTag = new Tag() {Title = tag};
                        newTag.Tweets.Add(newTweet);
                        this.tags.Add(newTag);
                    }
                }

                this.tags.SaveChanges();

                return RedirectToAction("Mine");
            }

            return View(tweet);
        }

        public ActionResult Mine()
        {
            var userId = this.UserProfile.Id;
            var myTweets = tweets.All()
                .Where(x => x.UserId == userId)
                .ProjectTo<TweeterPersonalViewModel>()
                .ToList();

            return View(myTweets);
        }
    }
}