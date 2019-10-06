using Advisor.Model;

namespace Advisor.Controller
{
    public interface IReviewController
    {
        void HandleSubmitReviewButtonClick();
        void SaveReview(Review review);
    }
}
