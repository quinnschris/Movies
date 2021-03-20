using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Movies.Models;

namespace Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult AddMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddMovies(AddMovie appResponse)
        {
            //When attempting to POST form, checks to make sure the model attributes are valid

            if (ModelState.IsValid)
            {
                TempStorage.AddFilm(appResponse);
                return View("Confirmation", appResponse);
            }
            else
            {
                return View();
            }
        }

        public IActionResult ViewMovies()
        {
            //Excludes any film with title "Independence Day" from being shown

            return View(TempStorage.Movies.Where(films => films.Title != "Independence Day"));
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
