using Advisor.Model;

namespace Advisor.Controllers
{
    public interface IReviewController
    {
        void HandleSubmitReviewButtonClick();
        void SaveReview(Review review);
    }
}
