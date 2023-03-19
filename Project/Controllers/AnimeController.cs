using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class AnimeController : Controller
    {
        public IActionResult AnimeDetails()
        {
            return View();
        }

        public IActionResult AnimeWatching()
        {
            return View();
        }
    }
}
