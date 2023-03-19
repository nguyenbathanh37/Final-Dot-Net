using Microsoft.AspNetCore.Mvc;

namespace Project.Controllers
{
    public class MainController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
