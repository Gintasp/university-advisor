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

        //Not implemented in the form
        //
        //void HandleCourseSelect(Course course);
        //void HandleAddCourseClick();
        //void HandleAddCourse(object sender, EventArgs e);
    }
}
