using Advisor.Models;
using System;

namespace Advisor.Controllers
{
    public interface IStudyProgramController
    {
        void LoadStudyProgramData();
        void HandlePreviousButtonClick();
        void HandleAddCourseLinkClick();
        void HandleAddCourse(object sender, EventArgs e);
        void HandleLeaveReviewClick();
        void HandleCourseSelect(Course course);
        void HandleCompareButtonClick();
    }
}