using Advisor.View;
using Advisor.Model;
using System.Collections.Generic;
using System.Linq;

namespace Advisor.Controller
{
    class StudyProgramComparisonController : IStudyProgramComparisonController
    {
        public StudyProgramComparisonView ComparisonView { get; set; }
        public StudyProgramSelectView SelectView { get; set; }
        public StudyProgram FirstStudyProgram { get; set; }
        public StudyProgram SecondStudyProgram { get; set; }
        public string ClickedSelectButtonName { get; set; }
        public bool SecondButtonClicked { get; set; }

        public StudyProgramComparisonController(StudyProgram firstStudyProgram)
        {
            FirstStudyProgram = firstStudyProgram;
        }

        public void HandleProgramSelectClick(bool wasSecondButtonClicked)
        {
            SecondButtonClicked = wasSecondButtonClicked;
            SelectView = new StudyProgramSelectView(this);
            SelectView.ShowDialog();
        }

        public void LoadUniversities()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            SelectView.UniversityList.Items.Clear();
            unis.ForEach(uni => SelectView.UniversityList.Items.Add(uni));
        }

        public void LoadFaculties(University uni)
        {
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == uni.Id).ToList();
            faculties.ForEach(faculty => SelectView.FacultyList.Items.Add(faculty));
        }

        public void LoadStudyPrograms(Faculty fac)
        {
            List<StudyProgram> programs = fac.StudyPrograms.ToList();
            programs.ForEach(program => SelectView.StudyProgramList.Items.Add(program));
        }

        public void SelectedStudyProgram(StudyProgram prog)
        {
            if(SecondButtonClicked)
            {
                SecondStudyProgram = prog;
            }
            else
            {
                FirstStudyProgram = prog;
            }
        }
    }
}
