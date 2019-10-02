using Advisor.Model;
using Advisor.View;
using System.Collections.Generic;
using System.Linq;

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
            List<StudyProgram> programs = DB.Instance.StudyPrograms.Where(p => p.Faculty.Id == faculty.Id).ToList();
            foreach (StudyProgram studyProgram in programs)
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
