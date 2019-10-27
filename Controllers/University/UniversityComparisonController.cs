using System.Collections.Generic;
using System.Linq;
using Advisor.Models;
using Advisor.Service.Statistics;

namespace Advisor.Controllers
{
    class UniversityComparisonController : IUniversityComparisonController
    {
        public void LoadUniversityList()
        {
            //List<University> unis = DB.Instance.Universities.ToList();
            //UniversityComparisonView.University1ComboBox.Items.Clear();
            //UniversityComparisonView.University2ComboBox.Items.Clear();
            //foreach (University uni in unis)
            //{
            //    UniversityComparisonView.University1ComboBox.Items.Add(uni);
            //    UniversityComparisonView.University2ComboBox.Items.Add(uni);
            //}
        }

        public void HandlePreviousButtonClick(University uni)
        {
            //UniversityComparisonView.Hide();
            //UniversityView = new UniversityView(new UniversityController(uni));
            //UniversityView.ShowDialog();
        }

        public void LoadStats(University uni)
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    join u in DB.Instance.Universities on f.University.Id equals u.Id
                                    where u.Id == uni.Id
                                    select r).ToList();
            statsData.AverageSalary = calculator.CalcReviewAverage(reviews, r => r.Salary, 2);
            statsData.OveralRating = calculator.CalcReviewAverage(reviews, r => r.OveralRating, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(reviews, r => r.Satisfaction, 1);
            statsData.FacultyCount = uni.Faculties.Count;
            statsData.ReviewCount = reviews.Count;
            statsData.StudyProgramCount = 0;
            foreach (Faculty f in uni.Faculties)
            {
                statsData.StudyProgramCount += f.StudyPrograms.Count;
            }
            if(statsData.ReviewCount!=0) statsData.RelevantIndustryPercentage = reviews.Count(r => r.RelevantIndustry==true)*100/statsData.ReviewCount;
            //UniversityComparisonView.StatsData = statsData;
        }
    }
}
