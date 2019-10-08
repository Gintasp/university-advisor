using System;
using System.Collections.Generic;
using System.Linq;
using Advisor.Model;
using Advisor.Service.Statistics;
using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public class FacultyComparisonController : IFacultyComparisonController
    {
        public FacultyComparisonView FacultyComparisonView { get; set; }
        public void LoadUniversities()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            FacultyComparisonView.UniversitySelectBox1.Items.Clear();
            FacultyComparisonView.UniversitySelectBox2.Items.Clear();
            foreach (University uni in unis)
            {
                FacultyComparisonView.UniversitySelectBox1.Items.Add(uni);
                FacultyComparisonView.UniversitySelectBox2.Items.Add(uni);
            }

        }
        public void LoadFaculties1()
        {
            FacultyComparisonView.FacultySelectBox1.Items.Clear();
            FacultyComparisonView.FacultySelectBox1.ResetText();
            University selectedUni = (University)FacultyComparisonView.UniversitySelectBox1.SelectedItem;
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == selectedUni.Id).ToList();
            foreach (Faculty fac in faculties)
            {
                FacultyComparisonView.FacultySelectBox1.Items.Add(fac);
            }
        }
        public void LoadFaculties2()
        {
            FacultyComparisonView.FacultySelectBox2.Items.Clear();
            FacultyComparisonView.FacultySelectBox2.ResetText();
            University selectedUni = (University)FacultyComparisonView.UniversitySelectBox2.SelectedItem;
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == selectedUni.Id).ToList();
            foreach (Faculty fac in faculties)
            {
                FacultyComparisonView.FacultySelectBox2.Items.Add(fac);
            }
        }
        public StatsData BuildFacultyStats(Faculty faculty)
        {
            List<Review> reviews = (from r in DB.Instance.Reviews
                                    join p in DB.Instance.StudyPrograms on r.StudyProgram.Id equals p.Id
                                    join f in DB.Instance.Faculties on p.Faculty.Id equals f.Id
                                    where f.Id == faculty.Id
                                    select r).ToList();
            StatisticCalculator calc = new StatisticCalculator();
            StatsData statsData = new StatsData()
            {
                ReviewCount = reviews.Count,
                OveralRating = calc.CalcReviewAverage(reviews, r=>r.OveralRating,1),
                Satisfaction = calc.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                AverageSalary = calc.CalcReviewAverage(reviews, r=> r.Salary,1),
                LecturerCount = faculty.Lecturers.Count,
                StudyProgramCount = faculty.StudyPrograms.Count
            };
            if (statsData.ReviewCount != 0)
                statsData.RelevantIndustryPercentage = reviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;


            return statsData;
        }
    }
}
