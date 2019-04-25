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
            public IActionResult Index()
            {
                return View(db.Users.ToList());
            }
        }
    
}
