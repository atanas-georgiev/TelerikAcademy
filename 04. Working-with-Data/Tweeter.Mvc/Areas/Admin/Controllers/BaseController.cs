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
    [Authorize(Roles = "Admin")]
    public abstract class BaseController : Controller
    {
       
    }

}