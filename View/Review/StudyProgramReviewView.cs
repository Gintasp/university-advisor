using System;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class StudyProgramReviewView : Form
    {
        public IStudyProgramReviewController StudyProgramReviewController { get; set; }
        public TextBox Income { get; set; }
        public RichTextBox TextReview { get; set; }
        public NumericUpDown Difficulty { get; set; }
        public NumericUpDown Satisfaction { get; set; }
        public NumericUpDown Rating { get; set; }
        public RadioButton RelevantIndustry { get; set; }
        public RadioButton IrrelevantIndustry { get; set; }
        public RadioButton FirstYear { get; set; }
        public RadioButton SecondYear { get; set; }
        public RadioButton ThirdYear { get; set; }
        public RadioButton FourthYear { get; set; }
        public StudyProgramReviewView(IStudyProgramReviewController studyProgramReviewController)
        {
            StudyProgramReviewController = studyProgramReviewController;
            studyProgramReviewController.StudyProgramReviewView = this;
            InitializeComponent();
            Income = txtIncome;
            Difficulty = numericUpDown1;
            Satisfaction = numericUpDown2;
            RelevantIndustry = radioButton1;
            IrrelevantIndustry = radioButton2;
            FirstYear = RadioFirst;
            SecondYear = RadioSecond;
            ThirdYear = RadioThird;
            FourthYear = RadioFourth;
            Rating = numericUpDown3;
            TextReview = ReviewTextBox;
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            StudyProgramReviewController.HandleSubmitReviewButtonClick();
        }
    }
}
