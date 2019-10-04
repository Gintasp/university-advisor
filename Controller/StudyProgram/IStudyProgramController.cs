using Advisor.Model;
using Advisor.View;
using System;

namespace Advisor.Controller
{
    public interface IStudyProgramController
    {
        StudyProgramView StudyProgramView { get; set; }
        void LoadStudyProgramData();
        void HandlePreviousButtonClick();
        void HandleAddCourseLinkClick();
        void HandleAddCourse(object sender, EventArgs e);
        void HandleLeaveReviewClick();
        void HandleCourseSelect(Course course);
    }
}