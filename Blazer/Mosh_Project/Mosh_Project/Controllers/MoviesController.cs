using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mosh_Project.Models;
using Mosh_Project.ViewModels;

namespace Mosh_Project.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie1 = new Movies { Name = "It is a random movie", Id = 1 };
            var customers = new List<Customer>
            {
                new Customer{Name = "customer1" },
                new Customer {Name = "customer2"}
            };
            var viewmodel = new RandomMovieViewModel
            {
                Movie = movie1,
                Customers = customers

            };
            return View(viewmodel);
        }

        ////Get: Movies/CustomerDetails
        //[Route("movies/customer/{id}")]
        //public ViewResult CustomerDetail(int id)
        //{
        //    foreach(Customer c in cu)
        //    return View
        //}

        //Get: Movies/Edit
        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        //Get: Movies/Index
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";

            return Content($"page index:{pageIndex} and sort by:{sortBy}");
        }

        //Get: Movies/released
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} / {month}");
        }


    }
}