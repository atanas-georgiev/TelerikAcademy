using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Tweeter.Data.Models;
using Tweeter.Data.Repositories;

namespace Tweeter.Mvc.Controllers
{
    public class BaseController : Controller
    {
        protected User UserProfile { get; private set; }
        IRepository<User> users = new GenericRepository<User>();

        protected override IAsyncResult BeginExecute(RequestContext requestContext, AsyncCallback callback, object state)
        {
            this.UserProfile = this.users.All().FirstOrDefault(u => u.UserName == requestContext.HttpContext.User.Identity.Name);

            return base.BeginExecute(requestContext, callback, state);
        }
    }
}