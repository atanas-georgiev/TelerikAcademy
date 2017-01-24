using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using LibrarySystem.Data.Models;
using LibrarySystem.Data.Repositories;

namespace LibrarySystem.Controllers
{
    public class HomeController : Controller
    {
        IRepository<Category> categories = new GenericRepository<Category>();
        IRepository<Book> books = new GenericRepository<Book>();

        [HttpGet]
        public ActionResult Read(int? id)
        {
            if (id == null)
            {
                var cats =
                    this.categories.All()
                        .Select(x => new
                        {
                            id = x.Id,
                            Name = x.Name,
                            hasChildren = x.Books.Any()
                        }).ToList();

                return this.Json(cats, JsonRequestBehavior.AllowGet);
            }
            else
            {
                var bks =
                    this.books.All().Where(x => x.CategoryId == id)
                        .Select(x => new
                        {
                            id = x.Id,
                            Name = x.Title,
                            hasChildren = false
                        }).ToList();

                return this.Json(bks, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}