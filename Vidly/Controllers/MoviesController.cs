using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        /*
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
        */
        // GET: Movies

        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };


            return View(movie);
            //return Content("hello world!");
            //return HttpNotFound();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy="name"});
        }
        /*
        public ActionResult Edit(int Id)
        {
            return Content("Id=" + Id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }
        */

    }
}