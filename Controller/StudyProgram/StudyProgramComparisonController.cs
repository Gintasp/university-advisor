using Advisor.View;
using Advisor.Model;
using System.Collections.Generic;
using System.Linq;
using Advisor.Service.Statistics;

namespace Advisor.Controller
{
    class StudyProgramComparisonController : IStudyProgramComparisonController
    {
        public StudyProgramComparisonView ComparisonView { get; set; }
        public StudyProgramSelectView SelectView { get; set; }
        public StudyProgram FirstStudyProgram { get; set; }
        public StudyProgram SecondStudyProgram { get; set; }
        public bool SecondButtonClicked { get; set; }

        public StudyProgramComparisonController(StudyProgram firstStudyProgram)
        {
            FirstStudyProgram = firstStudyProgram;
        }

        public void HandleProgramSelectClick(bool wasSecondButtonClicked)
        {
            SecondButtonClicked = wasSecondButtonClicked;
            SelectView = new StudyProgramSelectView(this);
            SelectView.ShowDialog();
        }

        public void LoadUniversities()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            SelectView.UniversityList.Items.Clear();
            unis.ForEach(uni => SelectView.UniversityList.Items.Add(uni));
        }

        public void LoadFaculties(University uni)
        {
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == uni.Id).ToList();
            faculties.ForEach(faculty => SelectView.FacultyList.Items.Add(faculty));
        }

        public void LoadStudyPrograms(Faculty fac)
        {
            List<StudyProgram> programs = fac.StudyPrograms.ToList();
            programs.ForEach(program => SelectView.StudyProgramList.Items.Add(program));
        }

        public void SelectedStudyProgram(StudyProgram prog)
        {
            if(SecondButtonClicked)
            {
                SecondStudyProgram = prog;
            }
            else
            {
                FirstStudyProgram = prog;
            }
            UpdateData();
        }

        public void UpdateData()
        {
            if (FirstStudyProgram != null)
            {
                StatsData statsData = new StatsData();
                StatisticCalculator calculator = new StatisticCalculator();
                List<Review> programReviews = FirstStudyProgram.Reviews.ToList();
                statsData.ReviewCount = programReviews.Count();
                statsData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);
                statsData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
                statsData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
                statsData.CourseCount = FirstStudyProgram.Courses.Count();
                if (statsData.ReviewCount != 0)
                {
                    statsData.RelevantIndustryPercentage = programReviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;
                }
                else
                {
                    statsData.RelevantIndustryPercentage = 0;
                }

                ComparisonView.FirstProgramData = statsData;
                ComparisonView.ShowFirstProgramStatsData();
            }

            if(SecondStudyProgram != null)
            {
                StatsData statsData = new StatsData();
                StatisticCalculator calculator = new StatisticCalculator();
                List<Review> programReviews = SecondStudyProgram.Reviews.ToList();
                statsData.ReviewCount = programReviews.Count();
                statsData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);
                statsData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
                statsData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
                statsData.CourseCount = SecondStudyProgram.Courses.Count();
                if (statsData.ReviewCount != 0)
                {
                    statsData.RelevantIndustryPercentage = programReviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;
                }
                else
                {
                    statsData.RelevantIndustryPercentage = 0;
                }

                ComparisonView.SecondProgramData = statsData;
                ComparisonView.ShowSecondProgramStatsData();
            }
        }
    }
}
