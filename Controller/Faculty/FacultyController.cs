using System.Collections.ObjectModel;
using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public FacultyListView FacultyListView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            FacultyListView = new FacultyListView(new FacultyListController(this), uni);
            FacultyListView.Show();
        }

        public void LoadStudyProgramData(Faculty faculty)
        {
            FacultyView.StudyProgramList.Items.Clear();
            foreach (StudyProgram studyProgram in faculty.StudyPrograms)
            {
                FacultyView.StudyProgramList.Items.Add(studyProgram);
            }
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }

        public void HandleLecturersButtonClick(Faculty faculty)
        {
            FacultyView.Hide();
            LecturerListView LecturerListView = new LecturerListView(new LecturerListController(faculty));
            LecturerListView.Show();
        }
    }
}
