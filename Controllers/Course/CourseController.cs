using Advisor.Models;
using System.Web.Mvc;
using System.Linq;
using Advisor.Services.Statistics;
using System.Web;
using Advisor.Services.IO;
using System;
using Advisor.Services.Validator;

namespace Advisor.Controllers
{
    public class CourseController : Controller, ICourseController
    {
        public IStatsBuilder StatsBuilder { get; set; }
        public IFileUploader FileUploader { get; set; }
        public IFileValidator FileValidator { get; set; }
        public CourseController(
            IStatsBuilder statsBuilder,
            IFileUploader fileUploader,
            IFileValidator fileValidator
        )
        {
            StatsBuilder = statsBuilder;
            FileUploader = fileUploader;
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
                ViewBag.StatsData = GetCourseStats(course);

                return View("/Views/Course/Course.cshtml");
            }

            return View("/Views/Shared/404.cshtml");
        }

        [HttpPost]
        [Route("upload", Name = "file_upload")]
        public ActionResult UploadFile(HttpPostedFileBase file, int course)
        {
            if (FileValidator.Validate(file))
            {
                FileUploader.UploadFile(file);
            }

            try
            {
                SaveFileIntoDB(file, course);

                return RedirectToRoute("course_page", new { id = course });
            }
            catch (Exception e)
            {
                return View("/Views/Shared/Error.cshtml");
            }
        }

        private bool SaveFileIntoDB(HttpPostedFileBase file, int courseId)
        {
            try
            {
                UploadedFile uploadedFile = new UploadedFile
                {
                    Course = DB.Instance.Courses.Where(c => c.Id == courseId).SingleOrDefault(),
                    FileName = file.FileName,
                    FilePath = "~/App_Data/uploads/" + file.FileName,
                    UploadedAt = DateTime.Now
                };
                DB.Instance.UploadedFiles.Add(uploadedFile);
                DB.Instance.SaveChanges();

                return true;
            }
            catch (Exception e)
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
