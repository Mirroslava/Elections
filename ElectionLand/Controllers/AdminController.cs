using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
//using System.Data.Entity;
using Microsoft.EntityFrameworkCore;
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
            return View();
        }

        //Canton///////////////////////////////////////////////////////////////
        public IActionResult Canton()
        {
            return View(db.VirtualCantons.ToList());
        }
        public IActionResult CreateCanton()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCanton(VirtualCanton virtualCanton)
        {

            virtualCanton.Id = db.VirtualCantons.Count() + (new Random()).Next(10, 100000);
            db.Entry(virtualCanton).State = EntityState.Added;
            db.VirtualCantons.Add(virtualCanton);
            await db.SaveChangesAsync();
            return RedirectToAction("Canton");
        }
        public IActionResult EditCanton(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                    return View("EditCanton", virtualCanton);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditCanton(VirtualCanton virtualCanton)
        {
            db.Entry(virtualCanton).State = EntityState.Modified;
            db.VirtualCantons.Update(virtualCanton);
            await db.SaveChangesAsync();
            return RedirectToAction("Canton");
        }
        [ActionName("DeleteCanton")]
        public IActionResult ConfirmDeleteCanton(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                    if (virtualCanton != null)
                        return View("DeleteCanton", virtualCanton);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCanton(int? id)
        {
            if (id != null)
            {
                VirtualCanton virtualCanton = db.VirtualCantons.FirstOrDefault(p => p.Id == id);
                if (virtualCanton != null)
                {
                    db.Entry(virtualCanton).State = EntityState.Deleted;
                    db.VirtualCantons.Remove(virtualCanton);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Canton");
                }
            }
            return NotFound();
        }
        /////////////////////////////////////////////////////////////////


        //District/////////////////////////////////////////////////////
        public IActionResult District()
        {
            return View(db.VirtualDistricts.Include(x => x.VirtualCanton).ToList());
        }
        public IActionResult CreateDistrict()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDistrict(VirtualDistrict virtualDistrict)
        {
            virtualDistrict.Id = db.VirtualDistricts.Count() + 2;
            db.VirtualDistricts.Add(virtualDistrict);
            await db.SaveChangesAsync();
            return RedirectToAction("District");
        }

        public IActionResult EditDistrict(int? id)
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
        public async Task<IActionResult> EditDistrict(VirtualDistrict virtualDistrict)
        {

            db.VirtualDistricts.Update(virtualDistrict);
            await db.SaveChangesAsync();
            return RedirectToAction("District");
        }
        [ActionName("DeleteDistrict")]
        public IActionResult ConfirmDeleteDistrict(int? id)
        {
            if (id != null)
            {
                VirtualDistrict virtualDistrict = db.VirtualDistricts.Include(x => x.VirtualCanton).FirstOrDefault(p => p.Id == id);
                if (virtualDistrict != null)
                    if (virtualDistrict != null)
                        return View(virtualDistrict);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> DeleteDistrict(int? id)
        {
            if (id != null)
            {
                VirtualDistrict virtualDistrict = db.VirtualDistricts.Include(x => x.VirtualCanton).FirstOrDefault(p => p.Id == id);
                if (virtualDistrict != null)
                {
                    db.VirtualDistricts.Remove(virtualDistrict);
                    await db.SaveChangesAsync();
                    return RedirectToAction("District");
                }
            }
            return NotFound();
        }
        ////////////////////////////////////////////////////////////////////////////////
        public IActionResult Elections()
        {
            return View(db.Elections.ToList());
        }
        public IActionResult CreateElections()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateElections(Election election)
        {
            election.Id = db.Elections.Count() + (new Random()).Next(10, 1000);
            db.Elections.Add(election);
            await db.SaveChangesAsync();
            return RedirectToAction("Admin");
        }

        public IActionResult EditElections(int? id)
        {
            if (id != null)
            {
                Election election = db.Elections.FirstOrDefault(p => p.Id == id);
                if (election != null)
                    return View(election);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> EditElections(Election election)
        {
            db.Elections.Update(election);
            await db.SaveChangesAsync();
            return RedirectToAction("Elections");
        }
        [ActionName("DeleteElections")]
        public IActionResult ConfirmDeleteElections(int? id)
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
        public async Task<IActionResult> DeleteElections(int? id)
        {
            if (id != null)
            {
                Election election = db.Elections.FirstOrDefault(p => p.Id == id);
                if (election != null)
                {
                    db.Elections.Remove(election);
                    await db.SaveChangesAsync();
                    return RedirectToAction("Elections");
                }
            }
            return NotFound();
        }

        //Candidacy/////////////////////////////////////////////////////
        public IActionResult Candidacy()
        {
            return View(db.SumbitCandidacies.Include(x => x.Election).Include(x => x.User).ToList());
        }
        public async Task<IActionResult> AnswerCandidacy(bool? answer, int? sumbitCandidacy_id)
        {
            if (answer != null || sumbitCandidacy_id != null)
            {
                SumbitCandidacy sumbitCandidacy = db.SumbitCandidacies.FirstOrDefault(x => x.Id == sumbitCandidacy_id);
                if (sumbitCandidacy != null)
                {
                    if (answer == true)
                    {
                        Candidate candidate = new Candidate { Id = db.Candidates.Count() + (new Random()).Next(10, 10000), ElectionId = sumbitCandidacy.ElectionId, Election = sumbitCandidacy.Election, User = sumbitCandidacy.User, UserId = sumbitCandidacy.UserId };
                        db.Candidates.Add(candidate);
                        await db.SaveChangesAsync();
                        db.SumbitCandidacies.Remove(sumbitCandidacy);
                        await db.SaveChangesAsync();
                        return View("Candidacy", db.SumbitCandidacies.Include(x => x.Election).Include(x => x.User).ToList());
                    }
                    else
                    {
                        db.SumbitCandidacies.Remove(sumbitCandidacy);
                        await db.SaveChangesAsync();
                        return View("Candidacy", db.SumbitCandidacies.Include(x => x.Election).Include(x => x.User).ToList());
                    }
                }
            }
            return NotFound();
        }
    }
}
