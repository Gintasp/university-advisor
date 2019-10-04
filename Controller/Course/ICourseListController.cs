using Advisor.Model;
using Advisor.View;
using System;

namespace Advisor.Controller
{
    public interface ICourseListController
    {
        CourseListView CourseListView { get; set; }
        void LoadCourseData();
        void HandleSelectedCourse(Course subject);
        void HandlePreviousFormButtonClick();
        void HandleAddCourseButtonClick();
        void HandleAddCourse(object sender, EventArgs e);
    }
}