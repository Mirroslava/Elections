using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ElectionLand.Models;
using Microsoft.EntityFrameworkCore;

namespace ElectionLand.Controllers
{


    public class HomeController : Controller
    {
        AplicationContext db;
        static int UserID = 0;
        static int electionID = 0;
        public HomeController(AplicationContext context)
        {
            db = context;
            
        }
        public IActionResult Start()
        {
            return View();
        }
        public IActionResult Index(int id)
        {
            int userId = id;
            var user = db.Users.Where(us => us.Id == userId);
            return View(user);
        }
        public IActionResult Vote()
        {
           
            return View(db.Users.ToList());
        }
        [Route("Home/Election/{election_id:int}")]
        public IActionResult Election(int? election_id)
        {
            ViewBag.UserStatusID = 1;
            if (election_id != null)
            {
                Election election = db.Elections.FirstOrDefault(x => x.Id == election_id);
                if (election != null)
                {
                    electionID = (int)election_id;
                    StatusToUser statusToUser = db.StatusToUsers.Include(x => x.UserStatus).Include(x => x.Election).FirstOrDefault(x => x.UserId == UserID && x.ElectionId == election_id);
                    if (statusToUser == null)
                    {
                        ViewBag.UserStatusID = 0;
                        ViewBag.UserStatusName = "Громадянин";
                    }
                    else
                    {
                        ViewBag.StatusToUser = statusToUser;
                        ViewBag.UsertToDistrict = db.UsetToVirtualDistricts.Include(x => x.User).Include(x => x.VirtualDistrict).FirstOrDefault(x => x.UserId == statusToUser.UserId);
                    }
                    return View(election);
                }
            }
            return NotFound();
        }

        [Route("Home/ShowUsersDistrict/{district_id:int}")]
        public IActionResult ShowUsersDistrict(int district_id)
        {
            List<User> users = db.UsetToVirtualDistricts.Include(x => x.User).Include(x => x.VirtualDistrict).Where(x => x.VirtualDistrictId == district_id).Select(x => x.User).ToList();
            return View("ShowUsers", users);
        }



        
       

        [Route("Home/ShowUsersCanton/{canton_id:int}")]
        public IActionResult ShowUsersCanton(int canton_id)
        {
            List<VirtualDistrict> virtualDistricts = db.VirtualDistricts.Include(x => x.VirtualCanton).Where(x => x.VirtualCantonId == canton_id).ToList();
            List<User> users = db.UsetToVirtualDistricts.Include(x => x.User).Include(x => x.VirtualDistrict).Where(x => virtualDistricts.Contains(x.VirtualDistrict)).Select(x => x.User).ToList();
            return View("ShowUsers", users);
        }

        [Route("Home/ShowDistrict")]
        public IActionResult ShowDistrict()
        {
            return View(db.VirtualDistricts.ToList());
        }
        [Route("Home/ShowCanton")]
        public IActionResult ShowCanton()
        {
            return View(db.VirtualCantons.ToList());
        }

        [Route("Home/ElectionSave/{election_id:int}")]
        public IActionResult ElectionSave(int election_id)
        {
            List<Candidate> candidates = db.Candidates.Include(x => x.User).Include(x => x.Election).Where(candidate => candidate.ElectionId == election_id).ToList();
            int countVoice = Math.Max(db.Voices.Where(voice => voice.ElectionId == election_id).Count(), 1);

            List<Stata> statas = candidates.Select(candidate => new Models.Stata
            {
                CandidateId = candidate.Id,
                Candidate = candidate,
                CountVoiceCondidate = db.Voices.Where(voice => voice.ElectionId == election_id && voice.CandidatId == candidate.Id).Count(),
            }).OrderByDescending(stata => stata.CountVoiceCondidate).ToList();
            if (statas.Count() > 0)
            {
                ViewBag.Winner = statas.FirstOrDefault().Candidate.User.FirstName + " " + statas.FirstOrDefault().Candidate.User.LastName;
                //db.Winners.Add(new Winner());
            }
            else
            {
                ViewBag.Winner = countVoice;
            }
            return View();
        }
        public IActionResult About(int id)
        {
            UserID = id;
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



        [Route("Home/CreateComplaint/{election_id:int}")]
        [HttpGet]
        public IActionResult CreateComplaint(int election_id)
        {
            ViewBag.ElectionID = election_id;

            return View("CreateComplaint");
        }

        [HttpPost]
        public IActionResult CreateComplaint(Complaints complaints)
        {

            complaints.Id = db.Complaintses.Count() + 1;
            db.Complaintses.Add(complaints);
            db.SaveChanges();
            return View("About");
        }

        [Route("Home/CreateAppeal/{user_id:int}")]
        [HttpGet]
        public IActionResult CreateAppeal(int user_id)
        {
            ViewBag.ElectionID = user_id;

            return View("CreateAppeal");
        }

        [HttpPost]
        public IActionResult CreateAppeal(Appeal appeal)
        {
            db.Appeals.Add(appeal);
            db.SaveChanges();

            appeal.Id = db.Appeals.Count() + 1;
            return View();
        }


        [Route("Home/ShowComplaints/{canton_id:int}/")]
        public IActionResult ShowComplaints(int canton_id)
        {
            List<VirtualDistrict> virtualDistricts = db.VirtualDistricts.Include(x => x.VirtualCanton).Where(x => x.VirtualCantonId == canton_id).ToList();
            List<Complaints> complaints = db.Complaintses.Include(x => x.Election).Include(x => x.VirtualDistrict).Where(x => virtualDistricts.Contains(x.VirtualDistrict) && x.ElectionId == electionID).ToList();
            return View(complaints);
        }

        [Route("Home/ShowAppeals/{canton_id:int}/")]
        public IActionResult ShowAppeals(int canton_id)
        {
            List<VirtualDistrict> virtualDistricts = db.VirtualDistricts.Include(x => x.VirtualCanton).Where(x => x.VirtualCantonId == canton_id).ToList();
            List<Appeal> appeals = db.Appeals.Include(x => x.Election).Include(x => x.VirtualDistrict).Where(x => virtualDistricts.Contains(x.VirtualDistrict) && x.ElectionId == electionID).ToList();
            return View(appeals);
        }



    }
}