using Advisor.View.Comparison;

namespace Advisor.Controller
{
    public interface ICourseComparisonController
    {
        CourseComparisonView CourseComparisonView { get; set; }
        void HandleCourseOneSelectClick();
        void HandleCourseTwoSelectClick();
    }
}