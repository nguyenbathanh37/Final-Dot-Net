using Microsoft.AspNetCore.Mvc;
using Project.Data;

namespace Project.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _db;
        public MenuViewComponent(ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var v = from t in _db.Menu
                    where t.MenuHide == 1
                    orderby t.MenuOrder ascending
                    select t;
            return View(v.ToList());
        }
    }
}
