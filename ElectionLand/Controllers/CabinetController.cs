using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        static int electionID;

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
            if (login == "admin1" && password == "admin1")
            {
                return RedirectToAction("Admin", "Admin");
            }
            var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            if (user == null)
            {
                ViewBag.Status = "Облікового запису з таким логіном та паролем ще не було створено!";
                return View("LogIn");
            }
            else
            {
                currentUserId = user.Id;
                try
                {
                    var districtId = db.UsetToVirtualDistricts.Where(d => d.UserId == user.Id).Last().VirtualDistrictId;
                    var district = db.VirtualDistricts.Where(d => d.Id == districtId);

                    ViewBag.DistrictTitle = district.Last().Title;
                    ViewBag.DistrictAddress = district.Last().Adress;
                }
                catch { }

                return RedirectToAction("Index");

            }

        }
        [HttpGet]
        public IActionResult Registration()
        {
            currentUserId = new int();
            return View("Registration");
        }
        [HttpPost]
        public IActionResult Registration(User user, int districtId)
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
            currentUserId = user.Id;
            return RedirectToAction("Index");
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
            else return Json(true);
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
        [HttpGet]
        public IActionResult Bulletin(int? election_id)
        {
            if (!db.Voices.Where(v => (v.UserId == currentUserId)&&(v.ElectionId==election_id)).Any())
            {
                electionID = (int)election_id;

                var model = new List<BulletinModel>();
                foreach (Candidate c in db.Candidates)
                {
                    if (c.ElectionId==election_id) model.Add(new BulletinModel { candidate = c, user = db.Users.FirstOrDefault(u => u.Id == c.Id) });

                }
                return View(model);
            }

            else
            {
                var candidateId = db.Voices.FirstOrDefault(v => v.UserId == currentUserId).CandidatId;
                var candidateUserId = db.Candidates.FirstOrDefault(c => c.Id == candidateId).UserId;
                return View("ThankPage", db.Users.FirstOrDefault(u=>u.Id==candidateUserId));
            }
        }
        [HttpPost]
        public IActionResult Bulletin(int radio)
        {
            var candidate = db.Candidates.FirstOrDefault(c=>c.Id==radio);
            db.Voices.Add(new Voice
            {
                Id = db.Voices.Count() + 1,
                CandidatId = candidate.Id,
                UserId = currentUserId,
                VirtualDistrictId = db.UsetToVirtualDistricts.FirstOrDefault(d => d.UserId == currentUserId).Id,
                ElectionId = electionID
                
            });
            db.SaveChanges();
            return View("ThankPage",db.Users.FirstOrDefault(u=>u.Id==candidate.Id));
        }


        public IActionResult Index()
        {
            int userId = currentUserId;
            var user = db.Users.FirstOrDefault(us => us.Id == userId);
            try
            {
                var districtId = db.UsetToVirtualDistricts.Where(d => d.UserId == user.Id).Last().VirtualDistrictId;
                var district = db.VirtualDistricts.Where(d => d.Id == districtId);

                ViewBag.DistrictTitle = district.Last().Title;
                ViewBag.DistrictAddress = district.Last().Adress;
            }
            catch { }
            return View(user);
        }
        [HttpGet]
        public IActionResult Edite()
        {

            int userId = currentUserId;
            var user = db.Users.Where(u => u.Id == currentUserId).Last();

            return View("Edite", user);
        }
        [HttpPost]
        public IActionResult Edite(User userChanges)
        {
            var currentUser = db.Users.Where(u => u.Id == currentUserId).Last();

            currentUser.FirstName = userChanges.FirstName;
            currentUser.LastName = userChanges.LastName;
            currentUser.Email = userChanges.Email;

            db.Users.Update(currentUser);
            db.SaveChangesAsync();

            var user = db.Users.Where(us => us.Id == currentUser.Id);
            return RedirectToAction("Index");

        }
    }
}
