using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElectionLand.Controllers
{
    public class ComplaintsController : Controller
    {
        AplicationContext db;


        [HttpPost]
        public IActionResult Privacy(Complaints complaints)
        {

            complaints.Id = db.Complaintses.Count() + 1;
            db.Complaintses.Add(complaints);
            db.SaveChanges();
            return View();
        }
    }
}