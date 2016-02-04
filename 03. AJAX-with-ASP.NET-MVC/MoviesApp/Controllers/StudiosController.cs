using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MoviesApp.Data.Models;
using MoviesApp.Data.Repositories;
using MoviesApp.Models;
using AutoMapper.QueryableExtensions;

namespace MoviesApp.Controllers
{
    public class StudiosController : Controller
    {
        GenericRepository<Studio> studios = new GenericRepository<Studio>();

        public ActionResult Index()
        {
            return this.View(new List<StudioViewModel>());
        }

        public ActionResult GetAll()
        {
            var allStudios = studios.All().ProjectTo<StudioViewModel>().ToList();
            Thread.Sleep(2222);
            return this.PartialView("_AllStudios", allStudios);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(StudioViewModel studio)
        {
            if (ModelState.IsValid)
            {
                studios.Add(new Studio()
                {
                    Name = studio.Name,
                    Address = studio.Address
                });
                studios.SaveChanges();
                return Content("Done!");
            }

            return PartialView("_Create", studio);
        }

        public ActionResult Delete(string id)
        {
            var idInt = int.Parse(id);
            var studio = studios.All().Where(s => s.Id == idInt).ProjectTo<StudioViewModel>().FirstOrDefault();

            return PartialView("_Delete");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, int? nothing)
        {
            var idInt = int.Parse(id);
            studios.Delete(idInt);
            studios.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Edit(string id)
        {
            var idInt = int.Parse(id);
            var studio = studios.All().Where(s => s.Id == idInt).ProjectTo<StudioViewModel>().FirstOrDefault();

            return PartialView("_Edit", studio);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudioViewModel studio)
        {
            if (ModelState.IsValid)
            {
                var studioDb = studios.GetById(studio.Id);
                studioDb.Name = studio.Name;
                studioDb.Address = studio.Address;
                studios.Update(studioDb);

                studios.SaveChanges();

                return Content("Done!");
            }

            return PartialView("_Edit", studio);
        }
    }
}