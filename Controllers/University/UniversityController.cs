using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Advisor.Controllers
{
    public class UniversityController : Controller, IUniversityController
    {
        public IStatsBuilder StatsBuilder { get; set; }

        public UniversityController(IStatsBuilder statsBuilder)
        {
            StatsBuilder = statsBuilder;
        }

        [Route("universities/{id?}", Name = "universities_page")]
        public ActionResult Individual(int? id)
        {
            University uni = new University();

            //Check if id in page route is not null because it otherwise breaks sql query
            if (id == null)
            {
                return View("/Views/Shared/404.cshtml");
            }

            //Data Adapter Use
            DataSet dataSet = new DataSet("University");
            using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                //Create a SqlDataAdapter for the Universities table.
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "University");
                connection.Open();
                // Create sql query to retrieve data
                SqlCommand command = new SqlCommand(
                    "SELECT Id, Title, Description, Website FROM Advisor.dbo.Universities WHERE Id=" + id + ";", connection);
                command.CommandType = CommandType.Text;
                // Set the SqlDataAdapter's SelectCommand.
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
                connection.Close();
            }

            if (dataSet.Tables[0].Rows.Count == 0)
            {
                return View("/Views/Shared/404.cshtml");
            }

            uni = GetUniInfoData(dataSet);

            if (uni == null)
            {
                return View("/Views/Shared/404.cshtml");
            }
            
            ViewBag.University = uni;
            ViewBag.StatsData = LoadStats(uni);

            return View("/Views/Advisor/University.cshtml");
        }

        [Route("universities", Name = "universities_list")]
        public ActionResult Index()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            ViewBag.Universities = unis;

            return View("/Views/Advisor/UniversityList.cshtml");
        }

        private StatsData LoadStats(University uni)
        {
            var stats = StatsBuilder.BuildUniversityStats(uni);
            StatsData statsData = new StatsData
            {
                OveralRating = stats.overal,
                FacultyCount = stats.faculty_count,
                StudyProgramCount = stats.study_program_count,
                Satisfaction = stats.satisfaction,
                AverageSalary = stats.salary,
                RelevantIndustryPercentage = stats.relevant_industry,
                DormitoryCount = stats.dormitory_count
            };

            return statsData;
        }

        private University GetUniInfoData(DataSet dataSet)
        {
            University uni = new University();
            uni.Id = GetDataSetRow<int>(dataSet, "Id");
            uni.Title = GetDataSetRow<string>(dataSet, "Title");
            uni.Description = GetDataSetRow<string>(dataSet, "Description");
            uni.Website = GetDataSetRow<string>(dataSet, "Website");

            uni.Faculties = (from  f in DB.Instance.Faculties
                             join u in DB.Instance.Universities on f.University.Id equals u.Id
                             where u.Id == uni.Id
                             select f).ToList();

            uni.Dormitories = (from d in DB.Instance.Dormitories
                               join u in DB.Instance.Universities on d.University.Id equals u.Id
                               where u.Id == uni.Id
                               select d).ToList();

            return uni;
        }

        private T GetDataSetRow<T>(DataSet dataSet, string columnName)
        {
            return (T)dataSet.Tables[0].Rows[0][columnName];
        }
    }
}
