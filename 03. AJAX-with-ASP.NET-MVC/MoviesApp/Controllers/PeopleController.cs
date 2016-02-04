using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using AutoMapper.QueryableExtensions;
using MoviesApp.Data.Models;
using MoviesApp.Data.Repositories;
using MoviesApp.Models;

namespace MoviesApp.Controllers
{
    public class PeopleController : Controller
    {
        GenericRepository<Person> people = new GenericRepository<Person>();
        GenericRepository<Studio> studios = new GenericRepository<Studio>();

        public ActionResult Index()
        {
            return this.View(new List<PersonViewModel>());
        }

        public ActionResult GetAll()
        {
            var allPeople = people.All().ProjectTo<PersonViewModel>().ToList();
            Thread.Sleep(2222);
            return this.PartialView("_AllPeople", allPeople);
        }

        public ActionResult Create()
        {
            var newPerson = new PersonViewModel()
            {
                AllStudios = studios.All().Select(x => x.Name).ToList()
            };

            return PartialView("_Create", newPerson);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                var studio = studios.All().FirstOrDefault(x => x.Name == person.StudioName);
                people.Add(new Person()
                {
                    Name = person.Name,
                    Age = person.Age,
                    Studio = studio
                });
                people.SaveChanges();
                return Content("Done!");
            }

            person.AllStudios = studios.All().Select(x => x.Name).ToList();
            return PartialView("_Create", person);
        }

        public ActionResult Delete()
        {
            return PartialView("_Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id)
        {
            var idInt = int.Parse(id);
            people.Delete(idInt);
            people.SaveChanges();

            return Content("Done!");
        }

        public ActionResult Edit(string id)
        {
            var idInt = int.Parse(id);
            var person = people.All().Where(s => s.Id == idInt).ProjectTo<PersonViewModel>().FirstOrDefault();
            person.AllStudios = studios.All().Select(x => x.Name).ToList();

            return PartialView("_Edit", person);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PersonViewModel person)
        {
            var studio = studios.All().FirstOrDefault(x => x.Name == person.StudioName);
            if (ModelState.IsValid)
            {
                var personDb = people.GetById(person.Id);
                personDb.Name = person.Name;
                personDb.Age = person.Age;
                personDb.Studio = studio;

                people.SaveChanges();

                return Content("Done!");
            }

            return PartialView("_Edit", person);
        }
    }
}