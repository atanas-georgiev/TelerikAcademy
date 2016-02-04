using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MoviesApp.Data.Models;
using MoviesApp.Data.Repositories;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class HomeController : Controller
    {
        GenericRepository<Person> people = new GenericRepository<Person>();
        GenericRepository<Studio> studios = new GenericRepository<Studio>();
        GenericRepository<Movie> movies = new GenericRepository<Movie>();

        public ActionResult Index()
        {
            var data = new HomeViewModel()
            {
                Movies = this.movies.All().OrderByDescending(x => x.Id).Take(5).ToList(),
                Studios = this.studios.All().OrderByDescending(x => x.Id).Take(5).ToList(),
                People = this.people.All().OrderByDescending(x => x.Id).Take(5).ToList()
            };

            return View(data);
        }
    }
}