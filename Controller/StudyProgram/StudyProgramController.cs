using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class StudyProgramController : IStudyProgramController
    {
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public Faculty Faculty { get; set; }
        public FacultyView FacultyView { get; set; }
        public University University { get; set; }
        public CourseListView CourseListView { get; set; }

        public StudyProgramController(StudyProgram studyProgram, Faculty faculty, University uni)
        {
            StudyProgram = studyProgram;
            Faculty = faculty;
            University = uni;
        }

        public void LoadStudyProgramData()
        {
            StudyProgramView.StudyProgram = StudyProgram;
            foreach(Review review in StudyProgram.Reviews)
            {
                StudyProgramView.ReviewListBox.Items.Add(review);
            }
        }

        public void HandlePreviousButtonClick()
        {
            StudyProgramView.Hide();
            FacultyView = new FacultyView(new FacultyController(), Faculty, University);
            FacultyView.Show();
        }

        public void HandleCoursesButtonClick()
        {
            StudyProgramView.Hide();
            CourseListView = new CourseListView(new CourseListController(StudyProgram));
            CourseListView.Show();
        }
    }
}
