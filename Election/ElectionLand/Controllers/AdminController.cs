using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectionLand.Controllers
{
    public class AdminController : Controller
    {

        AplicationContext db;
        public AdminController(AplicationContext context)
        {
            db = context;
        }
        public IActionResult Admin()
        {
            int userId = 1;
            var user = db.Users.Where(us => us.Id == userId);
            return View(user);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Election election)
        {
            db.Elections.Add(election);
            db.SaveChangesAsync();
            return RedirectToAction("Admin");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Election election = db.Elections.FirstOrDefault(p => p.Id == id);
                if (election != null)
                    if (election != null)
                        return View(election);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                Election election = db.Elections.FirstOrDefault(p => p.Id == id);
                if (election != null)
                {
                    db.Elections.Remove(election);
                    db.SaveChangesAsync();
                    return RedirectToAction("Admin");
                }
            }
            return NotFound();
        }
    }
}
