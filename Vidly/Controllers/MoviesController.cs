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
        /*
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12}")]
		public ActionResult ByReleaseDate(int year, int month)
		{
			return Content(year + "/" + month);
		}
        */
        // GET: Movies

        public ActionResult Index()
        {
           
            var movie = new List<Movie>
            {
                 new Movie { Name = "Shrek 2"},
                 new Movie { Name = "Armageddon"},
                 new Movie { Name = "Sharknado"},
                 new Movie { Name = "Silver Linings Playbook"},
                 new Movie { Name = "X-Men"},
                 new Movie { Name = "Independence Day"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie
            };

            return View(viewModel);
           
        }
       

    }
}