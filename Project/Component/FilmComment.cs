using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Component
{
    public class FilmCommentViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public FilmCommentViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync(string meta, int id)
        {
            var v = from f in _db.Films
                    from t in _db.FilmTypes
                    from c in _db.Comments
                    where f.FilmTypeID == t.FilmTypeID && f.FilmHide == 1 && f.FilmID == id && t.FilmTypeMeta == meta && f.FilmID == c.FilmID
                    select c;
            return View(v.ToList());
        }
    }
}
