using Advisor.View;
using Advisor.Model;
using System.Linq;
using System.Collections.Generic;

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

        public void LoadSubjectReviews()
        {
            List<Review> reviews = DB.Instance.Reviews.Where(r => r.StudySubject.Id == StudySubject.Id).ToList();
            foreach(Review review in reviews)
            {
                StudySubjectView.ReviewList.Items.Add(review);
            }
        }

        public void HandlePreviousClicked()
        {
            StudySubjectView.Hide();
            StudySubjectListView = new StudySubjectListView(new StudySubjectListController(StudyProgram));
            StudySubjectListView.Show();
        }
    }
}
