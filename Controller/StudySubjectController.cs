using Advisor.View;
using Advisor.Model;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public class StudySubjectController : IStudySubjectController
    {
        public StudySubjectView StudySubjectView { get; set; }
        public StudySubjectListView StudySubjectListView { get; set; }
        public StudyProgram StudyProgram { get; set; }
        public StudySubject StudySubject { get; set; }
        public StudySubjectController(StudyProgram studyProgram, StudySubject subject)
        {
            StudyProgram = studyProgram;
            StudySubject = subject;
        }

        public void HandleAddReview()
        {
            //TODO: Implement add review feature
        }

        public void LoadReviews(ListBox listbox)
        {
            //TODO: Fetch reviews of specific study subject
            listbox.Items.Clear();
            listbox.Items.Add("The best subject ever");
        }

        public void HandlePreviousClicked()
        {
            StudySubjectView.Hide();
            StudySubjectListView = new StudySubjectListView(new StudySubjectListController(StudyProgram));
            StudySubjectListView.Show();
        }
    }
}
