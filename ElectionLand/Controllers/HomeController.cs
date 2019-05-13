using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionLand.Models;

namespace ElectionLand.Controllers
{


    public class HomeController : Controller
    {
        AplicationContext db;
        public HomeController(AplicationContext context)
        {
            db = context;
        }
        public IActionResult Start()
        {
            return View();
        }
        public IActionResult Index()
        {
            int userId = 1;
            var user = db.Users.Where(us => us.Id == userId);
            return View(user);
        }
        public IActionResult About()
        {
            return View(db.Elections.ToList());
        }
        public IActionResult Contact()
        {
            return View(db.VirtualCantons.ToList());
        }
        public IActionResult Privacy()
        {
            return View(db.VirtualDistricts.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VirtualCanton virtualCanton)
        {
            db.VirtualCantons.Add(virtualCanton);
            db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }
        public IActionResult Edite(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                    return View(virtualCanton);
            }
            return NotFound();
        }
        [HttpPost]
        public  IActionResult Edite(VirtualCanton virtualCanton)
        {
            db.VirtualCantons.Update(virtualCanton);
             db.SaveChangesAsync();
            return RedirectToAction("Contact");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                    if (virtualCanton != null)
                    return View(virtualCanton);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                {
                    db.VirtualCantons.Remove(virtualCanton);
                   db.SaveChangesAsync();
                    return RedirectToAction("Contact");
                }
            }
            return NotFound();
        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View("Registration");
        }
        [HttpPost]
        public IActionResult Registration(User user)
        {
            user.Id = db.Users.Count()+1;
            db.Users.Add(user);
            db.UserToRoles.Add(new UserToRole { Id=db.UserToRoles.Count()+1, UserId = user.Id, RoleId = 1 });
            db.StatusToUsers.Add(new StatusToUser { Id = db.StatusToUsers.Count() + 1, UserId = user.Id, UserStatusId = 1 });
            db.SaveChanges();
            var user1 = db.Users.Where(u => u.Id == user.Id);
            return View("Index",user1);
        }
    }
}