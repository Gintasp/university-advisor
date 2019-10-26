namespace Advisor.Controllers
{
    public interface ICourseController
    {
        void LoadCourseData();
        void HandlePreviousClicked();
        void HandleCompareClick();
        void HandleLeaveReviewClick();
    }
}
