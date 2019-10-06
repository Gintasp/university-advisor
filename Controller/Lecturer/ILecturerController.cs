using System;
using Advisor.View;
using Advisor.Model;

namespace Advisor.Controller
{
    public interface ILecturerController
    {
        LecturerView LecturerView { get; set; }

        void LoadLecturerData();
        void HandleLeaveReviewClick();
        void HandlePreviousFormClick();

        //void HandleCourseSelect(Course course);
        //void HandleAddCourseClick();
        //void HandleAddCourse(object sender, EventArgs e);
    }
}
