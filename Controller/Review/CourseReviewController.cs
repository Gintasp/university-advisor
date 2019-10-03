using Advisor.View;

namespace Advisor.Controller
{
    public class CourseReviewController : ICourseReviewController
    {
        public CourseReviewView CourseReviewView { get; set; }

        public void HandleSubmitReviewButtonClick()
        {
            //TODO: Handle sending course review
        }
    }
}
