using Advisor.Model;
using Advisor.View.Comparison;
using System;
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

        }

        private void HandleCourseOneSelect(object sender, EventArgs e)
        {
            SelectPopup.Close();
            Course course = (Course)SelectPopup.ComboLast.SelectedItem;
            StatsData statsData = new StatsData()
            {
                //ReviewCount = course.Reviews.Count
                
            };
            CourseComparisonView.LoadCourseOne(course, statsData);
        }

        private void DisplayPopup()
        {
            if (SelectPopup == null)
            {
                SelectPopup = new SelectPopup();
            }
            SelectPopup.LabelLast.Text = "Course:";
            SelectPopup.ViewLoad += LoadPopupData;
            SelectPopup.FirstComboSelect += FilterByUniversity;
            SelectPopup.SecondComboSelect += FilterByFaculty;
            SelectPopup.Show();
        }

        private void FilterByUniversity(object sender, EventArgs e)
        {
            SelectPopup.ComboSecond.Items.Clear();
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
