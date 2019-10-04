using Advisor.View;

namespace Advisor.Controller
{
    public interface ICourseReviewController : IReviewController
    {
        CourseReviewView CourseReviewView { get; set; }
    }
}
