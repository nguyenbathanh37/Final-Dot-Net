using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index(string meta)
        {
            ViewData["meta"] = meta;
            return View();
        }

        public IActionResult FilmDetails(string meta, string id)
        {
            ViewData["meta"] = meta;
            var v = from f in _db.Films
                    from t in _db.FilmTypes
                    where f.FilmTypeID == t.FilmTypeID && f.FilmHide == 1 && f.FilmID == Int32.Parse(id) && t.FilmTypeMeta == meta
                    select f;
            return View(v.FirstOrDefault());
        }

        public IActionResult FilmWatch(string meta, string id)
        {
            ViewData["meta"] = meta;
            ViewData["id"] = Int32.Parse(id);
            return View();
        }
    }
}
