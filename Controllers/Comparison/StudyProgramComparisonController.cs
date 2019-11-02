using Advisor.Models;
using System.Collections.Generic;
using System.Linq;
using Advisor.Service.Statistics;
using System;

namespace Advisor.Controllers
{
    class StudyProgramComparisonController : IStudyProgramComparisonController
    {
        public void HandlePreviousFormClick()
        {
            //ComparisonView.Hide();
            //PreviousView.Show();
        }

        public void HandleProgramOneSelectClick()
        {
            DisplayPopup();
            //SelectPopup.SelectClick += HandleProgramOneSelect;
        }

        public void HandleProgramTwoSelectClick()
        {
            DisplayPopup();
            //SelectPopup.SelectClick += HandleProgramTwoSelect;
        }

        private void HandleProgramOneSelect(object sender, EventArgs e)
        {
            //StudyProgram program = (StudyProgram)SelectPopup.ComboLast.SelectedItem;
            //if (program != null)
            //{
            //    SelectPopup.Hide();
            //    StatsData statsData = UpdateData(program);
            //    ComparisonView.ShowFirstProgramStatsData(program, statsData);
            //    SelectPopup.SelectClick -= HandleProgramOneSelect;
            //}
        }

        private void HandleProgramTwoSelect(object sender, EventArgs e)
        {
            //StudyProgram program = (StudyProgram)SelectPopup.ComboLast.SelectedItem;
            //if (program != null)
            //{
            //    SelectPopup.Hide();
            //    StatsData statsData = UpdateData(program);
            //    ComparisonView.ShowSecondProgramStatsData(program, statsData);
            //    SelectPopup.SelectClick -= HandleProgramTwoSelect;
            //}
        }

        public StatsData UpdateData(StudyProgram program)
        {
            StatsData statsData = new StatsData();
            StatisticCalculator calculator = new StatisticCalculator();
            List<Review> programReviews = program.Reviews.ToList();
            statsData.ReviewCount = programReviews.Count();
            statsData.OveralRating = calculator.CalcReviewAverage(programReviews, r => r.OveralRating, 1);
            statsData.Satisfaction = calculator.CalcReviewAverage(programReviews, r => r.Satisfaction, 1);
            statsData.AverageSalary = calculator.CalcReviewAverage(programReviews, r => r.Salary, 1);
            statsData.CourseCount = program.Courses.Count();
            statsData.RelevantIndustryPercentage = 0;
            if (statsData.ReviewCount != 0)
            {
                statsData.RelevantIndustryPercentage = programReviews.Count(r => r.RelevantIndustry == true) * 100 / statsData.ReviewCount;
            }

            return statsData;
        }

        private void DisplayPopup()
        {
            //SelectPopup = new SelectPopup();
            //SelectPopup.FirstComboSelect += LoadFaculties;
            //SelectPopup.SecondComboSelect += LoadStudyPrograms;
            //SelectPopup.LabelLast.Text = "Study program:";
            //SelectPopup.ViewLoad += LoadPopupData;
            //SelectPopup.Show();
        }

        private void LoadPopupData(object sender, EventArgs e)
        {
            //SelectPopup.ComboFirst.Items.Clear();
            //SelectPopup.ComboSecond.Items.Clear();
            //SelectPopup.ComboLast.Items.Clear();
            //SelectPopup.ComboFirst.Items.AddRange(DB.Instance.Universities.ToArray());
        }

        public void LoadFaculties(object sender, EventArgs e)
        {
            //SelectPopup.ComboSecond.Items.Clear();
            //SelectPopup.ComboSecond.ResetText();
            //SelectPopup.ComboLast.ResetText();
            //University selectedUni = (University)SelectPopup.ComboFirst.SelectedItem;
            //SelectPopup.ComboSecond.Items.AddRange(DB.Instance.Faculties.Where(f => f.University.Id == selectedUni.Id).ToArray());
        }

        public void LoadStudyPrograms(object sender, EventArgs e)
        {
            //SelectPopup.ComboLast.Items.Clear();
            //SelectPopup.ComboLast.ResetText();
            //Faculty selectedFaculty = (Faculty)SelectPopup.ComboSecond.SelectedItem;
            //SelectPopup.ComboLast.Items.AddRange(DB.Instance.StudyPrograms.Where(c => c.Faculty.Id == selectedFaculty.Id).ToArray());
        }
    }
}
