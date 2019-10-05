using Advisor.View;

namespace Advisor.Controller
{
    public interface ICourseController
    {
        CourseView CourseView { get; set; }
        void LoadCourseReviews();
        void HandlePreviousClicked();
    }
}
