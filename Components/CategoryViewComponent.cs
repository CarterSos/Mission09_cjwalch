﻿using Microsoft.AspNetCore.Mvc;
using Mission09_cjwalch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cjwalch.Components
{
    public class CategoryViewComponent : ViewComponent
    {
        private IBookstoreRepository repo { get; set; }

        public CategoryViewComponent(IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];

            var types = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);


            return View(types);
        }

    }
}
