using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public StudySubjectController(StudyProgram studyProgram)
        {
            StudyProgram = studyProgram;
        }

        public void HandleAddReview()
        {
            //TODO: Implement add review feature
            throw new NotImplementedException();
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
