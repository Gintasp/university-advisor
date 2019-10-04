using Advisor.Model;
using Advisor.View;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public UniversityView UniversityView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            UniversityView = new UniversityView(new UniversityController(this), uni);
            UniversityView.Show();
        }

        public void LoadData(Faculty faculty)
        {
            FacultyView.StudyProgramList.Items.Clear();
            FacultyView.LecturerList.Items.Clear();
            List<StudyProgram> programs = faculty.StudyPrograms.ToList();
            List<Lecturer> lecturers = faculty.Lecturers.ToList();
            programs.ForEach(program => FacultyView.StudyProgramList.Items.Add(program));
            lecturers.ForEach(lecturer => FacultyView.LecturerList.Items.Add(lecturer));
        }

        public void HandleStudyProgramSelect(StudyProgram selectedProgram, Faculty faculty, University uni)
        {
            FacultyView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(selectedProgram, faculty, uni));
            StudyProgramView.Show();
        }

        public void HandleLecturerSelect(Lecturer lecturer, Faculty faculty, University university)
        {
            //TODO: Display lecturer form
        }
    }
}
