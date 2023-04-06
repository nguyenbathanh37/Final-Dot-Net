using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Component
{
    public class FilmSidebarViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public FilmSidebarViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var v = from t in _db.Films
                    where t.FilmHide == 1
                    orderby t.FilmOrder ascending
                    select t;
            return View(v.ToList());
        }
    }
}
