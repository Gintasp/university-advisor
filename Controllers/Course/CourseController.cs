using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Advisor.Services.Statistics;
using System.Web;
using Advisor.Services.IO;
using System;
using Advisor.Services.Validator;
using System.IO;

namespace Advisor.Controllers
{
    public class CourseController : Controller, ICourseController
    {
        private delegate StatsData Delegate<T>(T item);
        public IStatsBuilder StatsBuilder { get; set; }
        public IFileManager FileManager { get; set; }
        public IFileValidator FileValidator { get; set; }
        public CourseController(
            IStatsBuilder statsBuilder,
            IFileManager fileManager,
            IFileValidator fileValidator
        )
        {
            StatsBuilder = statsBuilder;
            FileManager = fileManager;
            FileValidator = fileValidator;
        }

        [Route("courses/{id?}", Name = "course_page")]
        public ActionResult Index(int? id)
        {
            if (id != null)
            {
                Course course = DB.Instance.Courses.Where(s => s.Id == id).SingleOrDefault();
                if (course == null)
                {
                    return View("/Views/Shared/404.cshtml");
                }

                ViewBag.Course = course;
                Delegate<Course> del = GetCourseStats;
                ViewBag.StatsData = del(course);

                return View("/Views/Course/Course.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        [HttpPost]
        [Route("upload", Name = "file_upload")]
        public ActionResult UploadFile(HttpPostedFileBase file, int course)
        {
            if (!User.IsInRole("User"))
            {
                return RedirectToRoute("login");
            }

            if (file == null || !FileValidator.Validate(file))
            {
                return View("/Views/Shared/Error.cshtml");
            }

            try
            {
                string hash = FileManager.UploadFile(file);
                if (hash != null)
                {
                    SaveFileIntoDB(file, hash, course);
                }

                return RedirectToRoute("course_page", new { id = course });
            }
            catch
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }

        [HttpGet]
        [Route("download/{id:int}", Name = "file_download")]
        public ActionResult DownloadFile(int? id)
        {
            UploadedFile uploadedFile = DB.Instance.UploadedFiles.Where(f => f.Id == id).SingleOrDefault();

            try
            {
                FileResult fileResponse = FileManager.DownloadFile(uploadedFile);

                return fileResponse;
            }
            catch
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }

        private bool SaveFileIntoDB(HttpPostedFileBase file, string hash, int courseId)
        {
            try
            {
                UploadedFile uploadedFile = new UploadedFile
                {
                    Course = DB.Instance.Courses.Where(c => c.Id == courseId).SingleOrDefault(),
                    FileName = file.FileName,
                    Hash = hash + Path.GetExtension(file.FileName),
                    UploadedAt = DateTime.Now
                };
                DB.Instance.UploadedFiles.Add(uploadedFile);
                DB.Instance.SaveChanges();

                return true;
            }
            catch
            {
                throw new InvalidOperationException();
            }
        }

        private StatsData GetCourseStats(Course course)
        {
            var stats = StatsBuilder.BuildCourseStats(course);
            StatsData statsData = new StatsData
            {
                ReviewCount = stats.review_count,
                Satisfaction = stats.satisfaction,
                Difficulty = stats.difficulty,
                Usefulness = stats.usefulness,
                Interesting = stats.interesting,
                Theory = stats.theory,
                Practice = stats.practice,
                OveralRating = stats.overal
            };

            return statsData;
        }
    }
}
