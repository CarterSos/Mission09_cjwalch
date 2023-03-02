using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mission09_cjwalch.Models;
using Mission09_cjwalch.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_cjwalch.Controllers
{
    public class HomeController : Controller
    {
        //private BookstoreContext context { get; set; } // added in videos
        ////public HomeController (WaterProjectContext temp)
        ////{
        ////    context = temp;
        ////}

        //public HomeController(BookstoreContext temp) => context = temp; // equivalent to same thing above (result is that context = temp) easy mode

        // above is the old way using context

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index(int pageNum = 1) // if nothing comes in then default to 1
        {
            int pageSize = 10;

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(x);
        }

    }
}
