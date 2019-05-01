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
            return View();
        }
        public IActionResult Contact()
        {
            return View(db.VirtualCantons.ToList());
        }
        public IActionResult Privacy()
        {
            return View(db.VirtualDistricts.ToList());
        }

    }
}