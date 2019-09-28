using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public class StudyProgramController : IStudyProgramController
    {
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public Faculty Faculty { get; set; }
        public FacultyView FacultyView { get; set; }
        public University University { get; set; }
        public StudySubjectListView StudySubjectListView { get; set; }

        public StudyProgramController(StudyProgram studyProgram, Faculty faculty, University uni)
        {
            StudyProgram = studyProgram;
            Faculty = faculty;
            University = uni;
        }

        public void LoadStudyProgramData(Label label)
        {
            //TODO: load StudyProgram data from DB to StudyProgramView (pass whole object)
            label.Text = StudyProgram.Title;
        }

        public void HandlePreviousButtonClick()
        {
            StudyProgramView.Hide();
            FacultyView = new FacultyView(new FacultyController(), Faculty, University);
            FacultyView.Show();
        }

        public void HandleStudySubjectsButtonClick()
        {
            StudyProgramView.Hide();
            StudySubjectListView = new StudySubjectListView(new StudySubjectListController(StudyProgram));
            StudySubjectListView.Show();
        }
    }
}
