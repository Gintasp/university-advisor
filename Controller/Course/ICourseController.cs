using Advisor.View;

namespace Advisor.Controller
{
    public interface ICourseController
    {
        CourseView CourseView { get; set; }
        void LoadCourseData();
        void HandlePreviousClicked();
        void HandleCompareClick();
        void HandleLeaveReviewClick();
    }
}
