using Advisor.View;

namespace Advisor.Controller
{
    class ReviewController : IReviewController
    {
        public CourseReviewView TextReviewView { get; set; }

        public StudyProgramReviewView StatisticReviewView { get; set; }

        //!! Both review forms use the same methods in their button actions !!
        //!! When implementing functionality it will be necessary to identify which form called the method !!
        public void HandleSubmitReviewButtonClick()
        {
            //TODO: Implement review object creation and storing
        }

        public void HandlePreviousFormLinkClick()
        {
            //TODO: Implement getting back to the form that called for review form
        }
    }
}
