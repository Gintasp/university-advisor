using Advisor.Controller;
using System;
using System.Windows.Forms;

namespace Advisor.View
{
    public partial class LecturerReviewView : Form
    {
        public ILecturerReviewController LecturerReviewController { get; set; }
        public NumericUpDown Competence { get; set; }
        public NumericUpDown Strictness { get; set; }
        public NumericUpDown Delivery { get; set; }
        public NumericUpDown Interesting { get; set; }
        public NumericUpDown Personality { get; set; }
        public NumericUpDown OveralRating { get; set; }
        public RichTextBox TextReview { get; set; }
        public LecturerReviewView(ILecturerReviewController lecturerReviewController)
        {
            LecturerReviewController = lecturerReviewController;
            LecturerReviewController.LecturerReviewView = this;
            InitializeComponent();
            Competence = numericUpDown1;
            Strictness = numericUpDown2;
            Delivery = numericUpDown4;
            Interesting = numericUpDown5;
            Personality = numericUpDown3;
            OveralRating = numericUpDown6;
            TextReview = richTextBox1;
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            LecturerReviewController.HandleSubmitReviewButtonClick();
        }
    }
}
