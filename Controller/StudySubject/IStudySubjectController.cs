using Advisor.View;

namespace Advisor.Controller
{
    public interface IStudySubjectController
    {
        StudySubjectView StudySubjectView { get; set; }
        void LoadSubjectReviews();
        void HandlePreviousClicked();
        void HandleAddReview();
    }
}
