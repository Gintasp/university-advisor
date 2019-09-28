using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public class StudySubjectListController : IStudySubjectListController
    {
        public StudySubjectListView StudySubjectListView { get; set; }
        public StudyProgram StudyProgram { get; set; }

        public StudySubjectListController(StudyProgram studyProgram)
        {
            StudyProgram = studyProgram;
        }

        public void LoadStudySubjectData(ListBox listbox)
        {
            //TODO: Load StudySubject data by StudyProgram from db (pass whole object)
            StudySubject studySubject = new StudySubject() { Title = "Matematika programu sistemoms :)" };
            listbox.Items.Add(studySubject.Title);
        }
    }
}
