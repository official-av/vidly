using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {   static List<Movie> mvsList = new List<Movie>
        {
            new Movie {Name = "Avengers",Id=1},
            new Movie {Name = "Die Hard",Id=2}
        };
        // GET: Movie
        public ActionResult Index()
        {
            return View(mvsList);
            //return Content("hello world");
            //return HttpNotFound();
            //return new EmptyResult();
           // return RedirectToAction("Index", "Home",new { page=1,sortby="name"});
        }

        public ActionResult Details(int Id)
        {
            return View(mvsList[Id-1]);
        }

        //for movies
        /*public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "name";
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }*/
    }
}