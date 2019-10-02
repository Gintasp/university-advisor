using Advisor.Model;
using Advisor.View;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    public class StudySubjectListController : IStudySubjectListController
    {
        public StudySubjectListView StudySubjectListView { get; set; }
        public StudyProgramView StudyProgramView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public StudySubjectView StudySubjectView { get; set; }

        public StudySubjectListController(StudyProgram studyProgram)
        {
            StudyProgram = studyProgram;
        }

        public void LoadStudySubjectData()
        {
            List<StudySubject> subjects = DB.Instance.StudySubjects.Where(s => s.StudyProgram.Id == StudyProgram.Id).ToList();
            foreach(StudySubject subject in subjects)
            {
                StudySubjectListView.StudySubjectList.Items.Add(subject);
            }
        }
        public void HandleSelectedSubject(string subjectTitle)
        {
            StudySubjectListView.Hide();
            StudySubjectView = new StudySubjectView(new StudySubjectController(StudyProgram));
            StudySubjectView.Show();
        }

        public void HandlePreviousFormButtonClick()
        {
            Faculty fac = GetFacultyByStudyProgram(StudyProgram);
            University uni = GetUniversityByFaculty(fac);

            StudySubjectListView.Hide();
            StudyProgramView = new StudyProgramView(new StudyProgramController(StudyProgram, fac, uni));
            StudyProgramView.Show();
        }

        private University GetUniversityByFaculty(Faculty fac)
        {
            return DB.Instance.Universities.Join(
                DB.Instance.Faculties,
                u => u.Id,
                f => f.University.Id,
                (u, f) => new { University = u, Faculty = f }
            )
            .Where(u => u.University.Id == fac.University.Id)
            .Select(u => u.University)
            .Distinct()
            .SingleOrDefault();
        }

        private Faculty GetFacultyByStudyProgram(StudyProgram program)
        {
            return DB.Instance.Faculties.Join(
                DB.Instance.StudyPrograms,
                f => f.Id,
                p => p.Faculty.Id,
                (f, p) => new { Faculty = f, StudyProgram = p }
            )
            .Where(p => p.StudyProgram.Id == program.Id)
            .Select(f => f.Faculty)
            .SingleOrDefault();
        }
    }
}
