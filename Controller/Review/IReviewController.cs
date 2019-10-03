using Advisor.View;

namespace Advisor.Controller
{
    public interface IReviewController
    {
        TextReviewView TextReviewView { get; set; }
        StatisticReviewView StatisticReviewView { get; set; }
        void HandleSubmitReviewButtonClick();
        void HandlePreviousFormLinkClick();
    }
}
