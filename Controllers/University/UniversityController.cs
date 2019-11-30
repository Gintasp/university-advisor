using Advisor.Models;
using Advisor.Services.Statistics;
using System.Linq;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

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
            University uni = DB.Instance.Universities.Where(u => u.Id == id).SingleOrDefault();

            //************************************************ Data Adapter Use (pretty much unnecessary as linq queries do this better) ************************************************
            University uniInfo = new University();

            DataSet dataSet = new DataSet("University");
            //Create a SqlConnection to the database.
            using (SqlConnection connection =
                       new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"))
            {
                //Create a SqlDataAdapter for the Universities table.
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.TableMappings.Add("Table", "University");

                // Open the connection.
                connection.Open();

                // Create a SqlCommand (aka query) to retrieve data
                SqlCommand command = new SqlCommand(
                    "SELECT Id, Title, Description, Website FROM Advisor.dbo.Universities WHERE Id=" + id +";", connection);
                command.CommandType = CommandType.Text;

                // Set the SqlDataAdapter's SelectCommand.
                adapter.SelectCommand = command;

                // Fill the DataSet.
                adapter.Fill(dataSet);

                // Close the connection.
                connection.Close();
            }

            if (uni == null)
            { 
                return View("/Views/Shared/404.cshtml");
            }

            uniInfo.Id = (int)dataSet.Tables[0].Rows[0]["Id"];              //probably unnecessary
            uniInfo.Title = (string)dataSet.Tables[0].Rows[0]["Title"];
            uniInfo.Description = (string)dataSet.Tables[0].Rows[0]["Description"];
            uniInfo.Website = (string)dataSet.Tables[0].Rows[0]["Website"]; //probably unneccesary

            ViewBag.UniversityInfo = uniInfo;
            //************************************************ End of Data Adapter Use ************************************************

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
    }
}
