using Microsoft.AspNetCore.Mvc;
using MovieStore.Repositories.Implementation;
using MovieStore.Repositories.Abstract;

namespace MovieStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMovie _movieService;
        public HomeController(IMovie movieService)
        {
            _movieService = movieService;
        }
        public IActionResult Index(string term = "", int currentPage = 1)
        {
            var movies = _movieService.List(term, true, currentPage);
            return View(movies);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult MovieDetail(int movieId)
        {
            var movie = _movieService.GetById(movieId);
            return View(movie);
        }

    }
}