using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Project.Data;
using Project.Migrations;
using Project.Models;
using System.Diagnostics;

namespace Project.Controllers
{
    public class MenuController : Controller
    {
        private readonly ApplicationDbContext _db;
        public MenuController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult GetMenu()
        {
            var v = from t in _db.Menu
                    where t.MenuHide == 1
                    orderby t.MenuOrder ascending
                    select t;            
            return PartialView("getMenu", v.ToList());
        }
    }
}
