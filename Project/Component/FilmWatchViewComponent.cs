using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Component
{
    public class FilmWatchViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public FilmWatchViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string meta, int id)
        {
            var v = from f in _db.Films
                    from t in _db.FilmTypes
                    where f.FilmTypeID == t.FilmTypeID && f.FilmHide == 1 && f.FilmID == id && t.FilmTypeMeta == meta
                    select f;
            string[] linkRoot = v.First().FilmLink.Split('=');
            v.First().FilmLink = "https://www.youtube.com/embed/" + linkRoot[1];
            return View(v.FirstOrDefault());
        }
    }
}
