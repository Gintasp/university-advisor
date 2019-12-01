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
            //Retrieve faculties using LINQ since data adapter makes it more complicated
            University uni = DB.Instance.Universities.Where(u => u.Id == id).SingleOrDefault();

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

            if (uni == null)
            {
                return View("/Views/Shared/404.cshtml");
            }

            ViewBag.UniversityInfo = GetUniInfoData(dataSet);
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
            University uniInfo = new University();
            uniInfo.Id = GetDataSetRow<int>(dataSet, "Id");
            uniInfo.Title = GetDataSetRow<string>(dataSet, "Title");
            uniInfo.Description = GetDataSetRow<string>(dataSet, "Description");
            uniInfo.Website = GetDataSetRow<string>(dataSet, "Website");

            return uniInfo;
        }

        private T GetDataSetRow<T>(DataSet dataSet, string columnName)
        {
            return (T)dataSet.Tables[0].Rows[0][columnName];
        }
    }
}
