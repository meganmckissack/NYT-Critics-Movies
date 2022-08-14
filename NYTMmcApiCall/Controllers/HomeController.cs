using Microsoft.AspNetCore.Mvc;
using NYTMvcApiCall.Models;

namespace NYTMvcApiCall.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var allMovies = Movie.GetMovies(EnvironmentVariables.ApiKey);
            return View(allMovies);
        }
    }
}
