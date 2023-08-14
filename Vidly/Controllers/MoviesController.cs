using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "OpenHeimer" };
            var customers = new List<Customer>()
            {
                new Customer() { Id = 1, Name = "Hassan" },
                new Customer() { Id = 1, Name = "Amina" },
                new Customer() { Id = 1, Name = "Abdul" },
            };

            var viewModel = new RandomMovieViewModel() { Movie = movie, Customers = customers };
            return View(viewModel);
            //return RedirectToAction("index","Home", new {x=4, name=6});
        }

        public ActionResult Index()
        {
            var movies = new List<Movie>()
            {
                new Movie() { Id = 1, Name = "You, Me and Dupree" },
                new Movie() { Id = 1, Name = "OpenHeimer" },
                new Movie() { Id = 1, Name = "Interstellar" },
            };
            return View(movies);
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(string year, string month)
        {
            return Content($"Movie Release DateTime is {month}, {year}");
        }
    }
}