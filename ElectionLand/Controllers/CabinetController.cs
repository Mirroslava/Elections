using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectionLand.Controllers
{
    public class CabinetController : Controller
    {
        AplicationContext db;
        public CabinetController(AplicationContext context)
        {
            db = context;
        }
        public IActionResult Bulletin()
        {
           
            return View();
        }
        public IActionResult Index()
        {
            int userId = 1;
            var user = db.Users.Where(us => us.Id == userId);
            return View(user);
        }
        public IActionResult Edite()
        {
            int userId = 1;
           User user = db.Users.FirstOrDefault(p => p.Id == userId);

             return View(user);
           
        }
        [HttpPost]
        public IActionResult Edite(User user)
        {
            db.Users.Update(user);
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
