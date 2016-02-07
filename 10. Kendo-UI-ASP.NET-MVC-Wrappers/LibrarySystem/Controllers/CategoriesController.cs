﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
﻿using AutoMapper.QueryableExtensions;
﻿using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
﻿using LibrarySystem.Data;
﻿using LibrarySystem.Data.Models;
﻿using LibrarySystem.Data.Repositories;
﻿using LibrarySystem.Models.Categories;

namespace LibrarySystem.Controllers
{
    public class CategoriesController : Controller
    {
        IRepository<Category> categories = new GenericRepository<Category>();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Categories_Read([DataSourceRequest]DataSourceRequest request)
        {
            var result = this.categories.All().ProjectTo<AddCategoryViewModel>().ToDataSourceResult(request);
            return Json(result);
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Categories_Create([DataSourceRequest]DataSourceRequest request, AddCategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category
                {
                    Name = category.Name
                };

                categories.Add(entity);
                categories.SaveChanges();
                category.Id = entity.Id;
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Categories_Update([DataSourceRequest]DataSourceRequest request, AddCategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category
                {
                    Id = category.Id,
                    Name = category.Name
                };

                categories.Update(entity);
                categories.SaveChanges();
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Categories_Destroy([DataSourceRequest]DataSourceRequest request, AddCategoryViewModel category)
        {
            if (ModelState.IsValid)
            {
                var entity = new Category
                {
                    Id = category.Id,
                    Name = category.Name
                };

                categories.Delete(entity);
                categories.SaveChanges();
            }

            return Json(new[] { category }.ToDataSourceResult(request, ModelState));
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
