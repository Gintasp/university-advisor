using Advisor.View;

namespace Advisor.Controller
{
    public interface IReviewController
    {
        TextReviewView TextReviewView { get; set; }
        StatsReviewView StatsReviewView { get; set; }

        void HandleSubmitReviewButtonClick();
        void HandlePreviousFormLinkClick();
    }
}
