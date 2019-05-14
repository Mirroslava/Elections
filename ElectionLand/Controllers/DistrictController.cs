using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectionLand.Controllers
{
    public class DistrictController : Controller
    {
        AplicationContext db;
        public DistrictController(AplicationContext context)
        {
            db = context;
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
        public IActionResult Create(VirtualDistrict virtualDistrict)
        {
            db.VirtualDistricts.Add(virtualDistrict);
            db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }

        public IActionResult Edite(int? id)
        {
            if (id != null)
            {
                VirtualDistrict virtualDistrict = db.VirtualDistricts.FirstOrDefault(p => p.Id == id);
                if (virtualDistrict != null)
                    return View(virtualDistrict);
            }
            return NotFound();
        }
        [HttpPost]
        public IActionResult Edite(VirtualDistrict virtualDistrict)
        {
            db.VirtualDistricts.Update(virtualDistrict);
            db.SaveChangesAsync();
            return RedirectToAction("Privacy");
        }

        [HttpGet]
        [ActionName("Delete")]
        public IActionResult ConfirmDelete(int? id)
        {
            if (id != null)
            {
                VirtualDistrict virtualDistrict = db.VirtualDistricts.FirstOrDefault(p => p.Id == id);
                if (virtualDistrict != null)
                    if (virtualDistrict != null)
                        return View(virtualDistrict);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id != null)
            {
                VirtualDistrict virtualDistrict = db.VirtualDistricts.FirstOrDefault(p => p.Id == id);
                if (virtualDistrict != null)
                {
                    db.VirtualDistricts.Remove(virtualDistrict);
                    db.SaveChangesAsync();
                    return RedirectToAction("Privacy");
                }
            }
            return NotFound();
        }
    }
}
