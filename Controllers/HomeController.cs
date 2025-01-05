using Microsoft.AspNetCore.Mvc;
using helloword.Models;

namespace helloword.Controllers
{
    public class HomeController : Controller
    {
        public static List<Movie> Movies { get; set; } = [
            new(){Title = "Journey of the Flower", Price = 10}
            ];
        public IActionResult Index()
        {
            ViewBag.Title = "HomePage";
            return View(Movies);
        }


        [HttpGet]
        public IActionResult CreateMovie()
        {
            ViewBag.Title = "New";
            return View();
        }
        [HttpPost]
        public IActionResult CreateMovie(Movie movie)
        {
            ViewBag.Title = "New";

            if (!ModelState.IsValid)
            {
                return View();
            }
            Movies.Add(movie);

            //Console.WriteLine(movie.Price);
            return RedirectToAction(nameof(Index));
        }
    }
}
