using System;

namespace Advisor.Controllers
{
    public interface IStudyProgramController
    {
        void HandleAddCourse(object sender, EventArgs e);
        void HandleLeaveReviewClick();
    }
}
