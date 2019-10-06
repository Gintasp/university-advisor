using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class CourseReviewView : Form
    {
        public ICourseReviewController CourseReviewController { get; set; }
        public NumericUpDown Difficulty { get; set; }
        public NumericUpDown Satisfaction { get; set; }
        public NumericUpDown Usefulness { get; set; }
        public NumericUpDown Interesting { get; set; }
        public NumericUpDown OveralRating { get; set; }
        public TrackBar TheoryPercentage { get; set; }
        public TrackBar PracticePercentage { get; set; }
        public RichTextBox TextReview { get; set; }
        public CourseReviewView(ICourseReviewController courseReviewController)
        {
            CourseReviewController = courseReviewController;
            courseReviewController.CourseReviewView = this;
            InitializeComponent();
            Difficulty = numericUpDown1;
            Satisfaction = numericUpDown2;
            Usefulness = numericUpDown4;
            Interesting = numericUpDown5;
            OveralRating = numericUpDown3;
            TheoryPercentage = trackBar1;
            PracticePercentage = trackBar2;
            TextReview = ReviewTextBox;
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            CourseReviewController.HandleSubmitReviewButtonClick();
        }
    }
}
