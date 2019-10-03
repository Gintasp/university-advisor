using Advisor.View;

namespace Advisor.Controller
{
    public interface IReviewController
    {
        CourseReviewView TextReviewView { get; set; }
        StudyProgramReviewView StatisticReviewView { get; set; }
        void HandleSubmitReviewButtonClick();
        void HandlePreviousFormLinkClick();
    }
}
