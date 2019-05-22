using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using ElectionLand.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElectionLand.Controllers
{
    public class StatisticController : Controller
    {
        AplicationContext db;
        static int elections = 0;
        public StatisticController(AplicationContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Users.ToList());
        }

        [Route("Statistic/Stata/{elections:int}")]
        public IActionResult Stata(int elections)
        {
            ViewData["Message"] = "Загальна статистика " + db.Elections.FirstOrDefault(elec => elec.Id == elections).Title;

            ViewBag.isVisibleCountWinCanton = false;
            ViewBag.isVisibleCountWinDistrict = false;

            List<Candidate> candidates = db.Candidates.Include(x => x.User).Include(x => x.Election).Where(candidate => candidate.ElectionId == elections).ToList();
            int countVoice = Math.Max(db.Voices.Where(voice => voice.ElectionId == elections).Count(), 1);

            List<Stata> statas = candidates.Select(candidate => new Models.Stata
            {
                CandidateId = candidate.Id,
                Candidate = candidate,
                CountVoiceCondidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.CandidatId == candidate.Id).Count(),
            }).OrderByDescending(stata => stata.CountVoiceCondidate).ToList();
            statas.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCondidate * 100) / countVoice, 4));
            return View(statas);
        }
        [Route("Statistic/Stata/{elections:int}/{canton:int}")]
        public IActionResult Stata(int elections, int canton)
        {
            ViewData["Message"] = "Загальна статистика по округу " +
                db.VirtualCantons.FirstOrDefault(can => can.Id == canton).Title +
                " " + db.Elections.FirstOrDefault(elec => elec.Id == elections).Title;

            ViewBag.isVisibleCountWinCanton = false;
            ViewBag.isVisibleCountWinDistrict = false;

            List<Candidate> candidates = db.Candidates.Include(x => x.User).Include(x => x.Election).Where(candidate => candidate.ElectionId == elections).ToList();
            int countVoice = Math.Max(db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton).Count(), 1);

            List<Stata> statas = candidates.Select(candidate => new Models.Stata
            {
                CandidateId = candidate.Id,
                Candidate = candidate,
                CountVoiceCondidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.CandidatId == candidate.Id && voice.VirtualDistrict.VirtualCantonId == canton).Count(),
            }).OrderByDescending(stata => stata.CountVoiceCondidate).ToList();
            statas.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCondidate * 100) / countVoice, 4));
            return View(statas);
        }

        [Route("Statistic/Stata/{elections:int}/{canton:int}/{district:int}")]
        public IActionResult Stata(int elections, int canton, int district)
        {
            ViewData["Message"] = "Загальна статистика по дільниці " +
            db.VirtualDistricts.FirstOrDefault(dis => dis.Id == district).Title +
            " в окрузі " + db.VirtualCantons.FirstOrDefault(can => can.Id == canton).Title +
            " " + db.Elections.FirstOrDefault(elec => elec.Id == elections).Title;

            ViewBag.isVisibleCountWinCanton = false;
            ViewBag.isVisibleCountWinDistrict = false;

            List<Candidate> candidates = db.Candidates.Include(x => x.User).Include(x => x.Election).Where(candidate => candidate.ElectionId == elections).ToList();
            int countVoice = Math.Max(db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrictId == district).Count(), 1);

            List<Stata> statas = candidates.Select(candidate => new Models.Stata
            {
                CandidateId = candidate.Id,
                Candidate = candidate,
                CountVoiceCondidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.CandidatId == candidate.Id && voice.VirtualDistrictId == district).Count(),
            }).OrderByDescending(stata => stata.CountVoiceCondidate).ToList();
            statas.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCondidate * 100) / countVoice, 4));
            return View(statas);
        }

        [Route("Statistic/StataCanton/{elections:int}")]
        public IActionResult StataCanton(int elections)
        {
            ViewData["Message"] = "Cтатистика округів " +
                db.Elections.FirstOrDefault(elec => elec.Id == elections).Title;

            List<VirtualCanton> virtualCantons = db.VirtualCantons.ToList();

            List<StataCanton> stataCantons = virtualCantons.Select(canton => new Models.StataCanton
            {
                VirtualCantonId = canton.Id,
                VirtualCanton = canton,
                CountVoice = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id).Count(),
                Candidate = db.Candidates.Include(x => x.Election).Include(x => x.User)
                .FirstOrDefault(cand => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id && voice.CandidatId == cand.Id).Count() ==
                db.Candidates.Include(x => x.Election).Include(x => x.User).Max(can => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id && voice.CandidatId == can.Id).Count()))
            }).ToList();

            stataCantons.ForEach(x => x.CandidateId = x.Candidate.Id);
            stataCantons.ForEach(x => x.CountVoiceCandidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == x.VirtualCantonId && voice.CandidatId == x.CandidateId).Count());
            stataCantons.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCandidate * 100) / Math.Max(stata.CountVoice, 1), 4));

            return View(stataCantons);
        }

        [Route("Statistic/StataDistrict/{elections:int}/{cantons:int}")]
        public IActionResult StataDistrict(int elections, int cantons)
        {
            ViewData["Message"] = "Cтатистика дільниць округа " + db.VirtualCantons.FirstOrDefault(x => x.Id == cantons).Title +
            " " + db.Elections.FirstOrDefault(elec => elec.Id == elections).Title;

            List<VirtualDistrict> virtualDistricts = db.VirtualDistricts.Where(distr => distr.VirtualCantonId == cantons).ToList();

            List<StataDistrict> stataDistricts = virtualDistricts.Select(distr => new StataDistrict
            {

                VirtualDistrictId = distr.Id,
                VirtualDistrict = distr,
                CountVoice = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrictId == distr.Id).Count(),
                Candidate = db.Candidates.Include(x => x.Election).Include(x => x.User)
                .FirstOrDefault(cand => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrictId == distr.Id && voice.CandidatId == cand.Id).Count() ==
                db.Candidates.Include(x => x.Election).Include(x => x.User).Max(can => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrictId == distr.Id && voice.CandidatId == can.Id).Count()))
            }).ToList();

            stataDistricts.ForEach(x => x.CandidateId = x.Candidate.Id);
            stataDistricts.ForEach(x => x.CountVoiceCandidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrictId == x.VirtualDistrictId && voice.CandidatId == x.CandidateId).Count());
            stataDistricts.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCandidate * 100) / Math.Max(stata.CountVoice, 1), 4));

            return View(stataDistricts);
        }
        public IActionResult FilterCandidate(int? election_id, double? overallRating, int? numberVictoriesCantons, double? ratingCantons, int? countRatingCantons)
        {
            if (election_id != null)
            {
                elections = (int)election_id;
            }



            List<Candidate> candidates = db.Candidates.Include(x => x.Election).Include(x => x.User).ToList();
            candidates = candidates.Where(x => x.ElectionId == elections).ToList();

            List<ResultCandidate> resultCandidates = new List<ResultCandidate>();



            if (overallRating == null) overallRating = 0;
            if (numberVictoriesCantons == null) numberVictoriesCantons = 0;
            if (ratingCantons == null) ratingCantons = 0;
            if (countRatingCantons == null) countRatingCantons = 0;

            int countVoice = Math.Max(db.Voices.Where(voice => voice.ElectionId == elections).Count(), 1);////////////////////////////////////


            List<VirtualCanton> virtualCantons = db.VirtualCantons.ToList();

            List<StataCanton> stataCantons = virtualCantons.Select(canton => new Models.StataCanton
            {
                VirtualCantonId = canton.Id,
                VirtualCanton = canton,
                CountVoice = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id).Count(),
                Candidate = db.Candidates.Include(x => x.Election).Include(x => x.User)
                .FirstOrDefault(cand => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id && voice.CandidatId == cand.Id).Count() ==
                db.Candidates.Include(x => x.Election).Include(x => x.User).Max(can => db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id && voice.CandidatId == can.Id).Count()))
            }).ToList();

            stataCantons.ForEach(x => x.CandidateId = x.Candidate.Id);
            stataCantons.ForEach(x => x.CountVoiceCandidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == x.VirtualCantonId && voice.CandidatId == x.CandidateId).Count());
            stataCantons.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCandidate * 100) / Math.Max(stata.CountVoice, 1), 4));


            for (int i = 0; i < candidates.Count(); i++)
            {
                double _overallRating = Math.Round(db.Voices.Where(voice => voice.ElectionId == elections && voice.CandidatId == candidates[i].Id).Count() * 100.0 / countVoice, 4);
                int _NumberVictoriesCantons = stataCantons.Where(x => x.CandidateId == candidates[i].Id).Count();


                List<Stata> statas = virtualCantons.Select(canton => new Models.Stata
                {
                    CandidateId = candidates[i].Id,
                    Candidate = candidates[i],
                    CountWinCanton = Math.Max(db.Voices.Where(voice => voice.ElectionId == elections && voice.VirtualDistrict.VirtualCantonId == canton.Id).Count(), 1),
                    CountVoiceCondidate = db.Voices.Where(voice => voice.ElectionId == elections && voice.CandidatId == candidates[i].Id && voice.VirtualDistrict.VirtualCantonId == canton.Id).Count(),
                }).ToList();
                statas.ForEach(stata => stata.Percent = Math.Round(((double)stata.CountVoiceCondidate * 100) / stata.CountWinCanton, 4));



                int _countRatingCantons = statas.Where(x => x.CandidateId == candidates[i].Id && x.Percent >= ratingCantons).Count();
                if (_overallRating >= overallRating && _NumberVictoriesCantons >= numberVictoriesCantons && _countRatingCantons >= countRatingCantons)
                {
                    resultCandidates.Add(new ResultCandidate { OverallRating = _overallRating, NumberVictoriesCantons = _NumberVictoriesCantons, CandidateId = candidates[i].Id, Candidate = candidates[i], CountRatingCantons = _countRatingCantons });
                }
            }

            FilterCandidates filterCandidates = new FilterCandidates
            {
                ResultCandidates = resultCandidates,
                OverallRating = (double)overallRating,
                NumberVictoriesCantons = (int)numberVictoriesCantons,
                RatingCantons = (double)ratingCantons,
                CountRatingCantons = (int)countRatingCantons,
            };
            return View(filterCandidates);
        }
    }
}



