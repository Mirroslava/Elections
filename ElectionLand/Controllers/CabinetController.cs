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
        static AplicationContext db;
        static int currentUserId;

        [HttpGet]
        public IActionResult LogIn()
        {
            currentUserId = new int();
            ViewBag.Status = "";
            return View("LogIn");
        }
        [HttpPost]
        public IActionResult LogIn(string login, string password)
        {
            var user = db.Users.Where(u => u.Login == login && u.Password == password);
            if (user.Count() == 0)
            {
                ViewBag.Status = "Облікового запису з таким логіном та паролем ще не було створено!";
                return View("LogIn");
            }
            else
            {
                currentUserId = user.Last().Id;
                var districtId = db.UsetToVirtualDistricts.Where(d => d.UserId == user.Last().Id).Last().VirtualDistrictId;
                var district = db.VirtualDistricts.Where(d => d.Id == districtId);

                ViewBag.DistrictTitle = district.Last().Title;
                ViewBag.DistrictAddress = district.Last().Adress;

                return View("../Home/Index", user);
               
            }

        }
        [HttpGet]
        public IActionResult Registration()
        {
            return View("Registration");
        }
        [HttpPost]
        public IActionResult Registration(User user,int districtId)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            user.Id = db.Users.Count() + 1;
            db.Users.Add(user);
            db.UserToRoles.Add(new UserToRole { Id = db.UserToRoles.Count() + 1, UserId = user.Id, RoleId = 1 });
            db.StatusToUsers.Add(new StatusToUser { Id = db.StatusToUsers.Count() + 1, UserId = user.Id, UserStatusId = 1 });
            db.UsetToVirtualDistricts.Add(new UsetToVirtualDistrict { Id = db.UsetToVirtualDistricts.Count() + 1, UserId = user.Id, VirtualDistrictId = districtId });
            db.SaveChanges();
            var user1 = db.Users.Where(u => u.Id == user.Id);
            return View("Index", user1);
        }
        #region BirthDate
        public JsonResult BirthDateCheck(DateTime BirthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;
            if (BirthDate > today.AddYears(-age)) age--;

            if (age < 18) return Json(data: "У вас ще немає права робити голос");
            else return Json(true);
        }
        #endregion
        public IActionResult UniquePINCheck(long pin)
        { 
            if (db.Users.Where(u => u.PIN == pin).Any()) return Json("Користувач з таким кодом вже був зареєстрований");
            else return Json(true) ;
        }

        [HttpPost]
        public JsonResult UniqueLoginCheck(string Login)
        {
            //if (db.Users.Where(u => u.Login == Login).Any()) return Json("User with such Login has been already registered");
            //else return Json(true);
            return Json(!db.Users.Where(u => u.Login == Login).Any());
        }

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
            int userId = currentUserId;
            var user = db.Users.Where(us => us.Id == userId);
            return View(user);
        }
        public IActionResult Edite()
        {
           int userId = currentUserId;
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
