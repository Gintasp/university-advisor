using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

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
            foreach(StudySubject subject in StudyProgram.StudySubjects)
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
            //TODO: Fetch faculty and uni from DB by StudyProgram;
            StudySubjectListView.Hide();
            StudyProgramView = new StudyProgramView(
                new StudyProgramController(
                    StudyProgram,
                    new Faculty() { Title = "MIF" },
                    new University() { Title = "Vilnius University" }
                )
            );
            StudyProgramView.Show();
        }
    }
}
