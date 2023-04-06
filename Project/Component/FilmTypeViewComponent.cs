using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Component
{
    public class FilmTypeViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public FilmTypeViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var v = from t in _db.FilmTypes
                    where t.FilmTypeHide == true
                    orderby t.FilmTypeOrder ascending
                    select t;
            return View(v.ToList());
        }
    }
}
