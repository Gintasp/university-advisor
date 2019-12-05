using Advisor.Models;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System;
using Advisor.Services.Statistics;

namespace Advisor.Controllers
{
    public class RatingsController : Controller
    {
        private IStatsBuilder StatsBuilder { get; set; }
        public struct StudyProgramInformation
        {
            public StudyProgram StudyProgram { get; set; }
            public University University { get; set; }
            public double Overal { get; set; }
        }

        public struct UniversityInformation
        {
            public University University { get; set; }
            public double Overal { get; set; }
        }

        public RatingsController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }


        [HttpGet]
        [Route("ratings", Name = "ratings_page")]
        public ActionResult Index()
        {
            ViewBag.Universities = GetUnis();
            ViewBag.StudyPrograms = GetStudyPrograms();

            return View("/Views/Advisor/Ratings/Ratings.cshtml");
        }

        private List<UniversityInformation> GetUnis()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            University temp;
            List<UniversityInformation> list = new List<UniversityInformation>();

            for (int i = 0; i < unis.Count; i++)
            {
                var statsI = StatsBuilder.BuildUniversityStats(unis[i]);
                for (int j = i + 1; j < unis.Count; j++)
                {
                    var statsJ = StatsBuilder.BuildUniversityStats(unis[j]);
                    if (statsI.overal < statsJ.overal)
                    {
                        temp = unis[i];
                        unis[i] = unis[j];
                        unis[j] = temp;
                        statsI = StatsBuilder.BuildUniversityStats(unis[i]);
                    }
                }
                UniversityInformation info = new UniversityInformation
                {
                    University = unis[i],
                    Overal = Math.Round(statsI.overal, 1)
                };
                list.Add(info);
            }

            return list;
        }

        private List<StudyProgramInformation> GetStudyPrograms()
        {
            List<StudyProgram> programs = DB.Instance.StudyPrograms.ToList();
            StudyProgram temp;
            List<StudyProgramInformation> list = new List<StudyProgramInformation>();

            for (int i = 0; i < programs.Count; i++)
            {
                for (int j = i + 1; j < programs.Count; j++)
                {
                    if (Math.Round(programs[i].Reviews.Average(r => r.OveralRating), 2) <
                        Math.Round(programs[j].Reviews.Average(r => r.OveralRating), 2))
                    {
                        temp = programs[i];
                        programs[i] = programs[j];
                        programs[j] = temp;
                    }
                }
                StudyProgram program = programs[i];
                StudyProgramInformation info = new StudyProgramInformation
                {
                    StudyProgram = programs[i],
                    Overal = Math.Round(programs[i].Reviews.Average(r => r.OveralRating), 1),
                    University = (from p in DB.Instance.StudyPrograms
                                  join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                  join u in DB.Instance.Universities on f.University.Id equals u.Id
                                  where p.Id == program.Id
                                  select u).FirstOrDefault()
                };
                list.Add(info);
            }

            return list;
        }
    }
}
