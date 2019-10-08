using Advisor.Model;
using Advisor.Service.Statistics;
using Advisor.View.Comparison;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class CourseComparisonController : ICourseComparisonController
    {
        public CourseComparisonView CourseComparisonView { get; set; }
        public SelectPopup SelectPopup { get; set; }

        public void HandleCourseOneSelectClick()
        {
            DisplayPopup();
            SelectPopup.SelectClick += HandleCourseOneSelect;
        }

        public void HandleCourseTwoSelectClick()
        {
            DisplayPopup();
            SelectPopup.SelectClick += HandleCourseTwoSelect;
        }

        private void HandleCourseOneSelect(object sender, EventArgs e)
        {
            Course course = (Course) SelectPopup.ComboLast.SelectedItem;
            if(course != null)
            {
                SelectPopup.Hide();
                StatsData statsData = BuildCourseStats(course);
                CourseComparisonView.LoadCourseOne(course, statsData);
                SelectPopup.SelectClick -= HandleCourseOneSelect;
            }
        }

        private void HandleCourseTwoSelect(object sender, EventArgs e)
        {
            Course course = (Course) SelectPopup.ComboLast.SelectedItem;
            if(course != null)
            {
                SelectPopup.Hide();
                StatsData statsData = BuildCourseStats(course);
                CourseComparisonView.LoadCourseTwo(course, statsData);
                SelectPopup.SelectClick -= HandleCourseTwoSelect;
            }
        }

        private StatsData BuildCourseStats(Course course)
        {
            List<Review> reviews = course.Reviews.ToList();
            StatisticCalculator calc = new StatisticCalculator();
            StatsData statsData = new StatsData()
            {
                ReviewCount = reviews.Count,
                Satisfaction = calc.CalcReviewAverage(reviews, r => r.Satisfaction, 1),
                Difficulty = calc.CalcReviewAverage(reviews, r => r.Difficulty, 1),
                Usefulness = calc.CalcReviewAverage(reviews, r => r.Usefulness, 1),
                Interesting = calc.CalcReviewAverage(reviews, r => r.Interesting, 1),
                Theory = calc.CalcReviewAverage(reviews, r => r.TheoryPercentage, 1),
                Practice = calc.CalcReviewAverage(reviews, r => r.PracticePercentage, 1)
            };

            return statsData;
        }

        private void DisplayPopup()
        {
            SelectPopup = new SelectPopup();
            SelectPopup.FirstComboSelect += FilterByUniversity;
            SelectPopup.SecondComboSelect += FilterByFaculty;
            SelectPopup.LabelLast.Text = "Course:";
            SelectPopup.ViewLoad += LoadPopupData;
            SelectPopup.Show();
        }

        private void FilterByUniversity(object sender, EventArgs e)
        {
            SelectPopup.ComboSecond.Items.Clear();
            SelectPopup.ComboSecond.ResetText();
            SelectPopup.ComboLast.ResetText();
            University selectedUni = (University) SelectPopup.ComboFirst.SelectedItem;
            SelectPopup.ComboSecond.Items.AddRange(
                DB.Instance.Faculties.Where(
                    f => f.University.Id == selectedUni.Id
                ).ToArray()
            );
        }

        private void FilterByFaculty(object sender, EventArgs e)
        {
            SelectPopup.ComboLast.Items.Clear();
            SelectPopup.ComboLast.ResetText();
            Faculty selectedFaculty = (Faculty) SelectPopup.ComboSecond.SelectedItem;
            SelectPopup.ComboLast.Items.AddRange(
                DB.Instance.Courses.Where(
                    c => c.StudyProgram.Faculty.Id == selectedFaculty.Id
                ).ToArray()
            );
        }

        private void LoadPopupData(object sender, EventArgs e)
        {
            SelectPopup.ComboFirst.Items.Clear();
            SelectPopup.ComboSecond.Items.Clear();
            SelectPopup.ComboLast.Items.Clear();
            SelectPopup.ComboFirst.Items.AddRange(DB.Instance.Universities.ToArray());
        }
    }
}
