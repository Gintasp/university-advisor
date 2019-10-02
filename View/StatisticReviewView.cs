using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class StatisticReviewView : Form
    {
        public IReviewController ReviewController { get; set; }
        public StatisticReviewView(IReviewController reviewController)
        {
            ReviewController = reviewController;
            reviewController.StatsReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            ReviewController.HandleSubmitReviewButtonClick();
        }

        private void OnPreviousFormLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ReviewController.HandlePreviousFormLinkClick();
        }
    }
}
