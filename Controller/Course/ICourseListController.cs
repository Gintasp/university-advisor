using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface ICourseListController
    {
        CourseListView CourseListView { get; set; }
        void LoadCourseData();
        void HandleSelectedCourse(Course subject);
        void HandlePreviousFormButtonClick();
    }
}