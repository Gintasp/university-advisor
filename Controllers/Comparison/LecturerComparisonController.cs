using System;
using System.Linq;
using Advisor.Models;
using System.Collections.Generic;
using Advisor.Service.Statistics;

namespace Advisor.Controllers
{
    public class LecturerComparisonController : ILecturerComparisonController
    {
        public void HandleLecturerOneChooseClick()
        {
            DisplayPopup();
            //SelectPopup.SelectClick += HandleLecturerOneSelectClick;
        }

        private void HandleLecturerOneSelectClick(object sender, EventArgs e)
        {
            //Lecturer lecturer = (Lecturer)SelectPopup.ComboLast.SelectedItem;
            //if (lecturer != null)
            //{
            //    SelectPopup.Hide();
            //    StatsData statsData = BuildCourseStats(lecturer);
            //    LecturerComparisonView.LoadLecturerOne(lecturer, statsData);
            //    SelectPopup.SelectClick -= HandleLecturerOneSelectClick;
            //}
        }

        public void HandleLecturerTwoChooseClick()
        {
            DisplayPopup();
            //SelectPopup.SelectClick += HandleLecturerTwoSelectClick; ;
        }

        private void HandleLecturerTwoSelectClick(object sender, EventArgs e)
        {
            //Lecturer lecturer = (Lecturer)SelectPopup.ComboLast.SelectedItem;
            //if (lecturer != null)
            //{
            //    SelectPopup.Hide();
            //    StatsData statsData = BuildCourseStats(lecturer);
            //    LecturerComparisonView.LoadLecturerTwo(lecturer, statsData);
            //    SelectPopup.SelectClick -= HandleLecturerTwoSelectClick;
            //}
        }

        private void DisplayPopup()
        {
            //SelectPopup = new SelectPopup();
            //SelectPopup.FirstComboSelect += FilterByUniversity;
            //SelectPopup.SecondComboSelect += FilterbyFaculty;
            //SelectPopup.LabelLast.Text = "Lecturer:";
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

        private void FilterByUniversity(object sender, System.EventArgs e)
        {
            //SelectPopup.ComboSecond.Items.Clear();
            //SelectPopup.ComboSecond.ResetText();
            //SelectPopup.ComboLast.ResetText();
            //University selectedUni = (University)SelectPopup.ComboFirst.SelectedItem;
            //SelectPopup.ComboSecond.Items.AddRange(
            //    DB.Instance.Faculties.Where(
            //        f => f.University.Id == selectedUni.Id
            //    ).ToArray()
            //);
        }

        private void FilterbyFaculty(object sender, System.EventArgs e)
        {
            //SelectPopup.ComboLast.Items.Clear();
            //SelectPopup.ComboLast.ResetText();
            //Faculty selectedFaculty = (Faculty)SelectPopup.ComboSecond.SelectedItem;
            //SelectPopup.ComboLast.Items.AddRange(
            //    DB.Instance.Lecturers.Where(
            //        c => c.Faculty.Id == selectedFaculty.Id
            //    ).ToArray()
            //);
        }

        private StatsData BuildCourseStats(Lecturer lecturer)
        {
            List<Review> reviews = lecturer.Reviews.ToList();
            StatisticCalculator calc = new StatisticCalculator();
            StatsData statsData = new StatsData()
            {
                ReviewCount = reviews.Count,
                OveralRating = calc.CalcReviewAverage(reviews, r => r.OveralRating, 1),
                Competence = calc.CalcReviewAverage(reviews, r => r.Competence, 1),
                Strictness = calc.CalcReviewAverage(reviews, r => r.Strictness, 1),
                Delivery = calc.CalcReviewAverage(reviews, r => r.Delivery, 1),
                Personality = calc.CalcReviewAverage(reviews, r => r.Personality, 1),
            };

            return statsData;
        }

        public void HandlePreviousButtonClick(Lecturer lec)
        {
            //LecturerComparisonView.Hide();
            //LecturerView = new LecturerView(new LecturerController(lec));
            //LecturerView.ShowDialog();
        }
    }
}
