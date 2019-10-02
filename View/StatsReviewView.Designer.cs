namespace Advisor.View
{
    partial class StatsReviewView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.previousForm = new System.Windows.Forms.LinkLabel();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.ReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.ReviewInputTitle = new System.Windows.Forms.Label();
            this.txtOccupation = new System.Windows.Forms.TextBox();
            this.OccupationLabel = new System.Windows.Forms.Label();
            this.graduationDatePicker = new System.Windows.Forms.DateTimePicker();
            this.GraduationLabel = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.ReviewScoreBar = new System.Windows.Forms.TrackBar();
            this.Incomelabel = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.durationLabel = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreBar)).BeginInit();
            this.SuspendLayout();
            // 
            // previousForm
            // 
            this.previousForm.AutoSize = true;
            this.previousForm.Location = new System.Drawing.Point(12, 9);
            this.previousForm.Name = "previousForm";
            this.previousForm.Size = new System.Drawing.Size(19, 13);
            this.previousForm.TabIndex = 9;
            this.previousForm.TabStop = true;
            this.previousForm.Text = "<<";
            this.previousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormLinkClick);
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitReview.Location = new System.Drawing.Point(295, 570);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(414, 37);
            this.btnSubmitReview.TabIndex = 7;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.OnSubmitReviewButtonClick);
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Location = new System.Drawing.Point(295, 301);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(414, 212);
            this.ReviewTextBox.TabIndex = 6;
            this.ReviewTextBox.Text = "";
            // 
            // ReviewInputTitle
            // 
            this.ReviewInputTitle.AutoSize = true;
            this.ReviewInputTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.ReviewInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewInputTitle.Location = new System.Drawing.Point(365, 92);
            this.ReviewInputTitle.Name = "ReviewInputTitle";
            this.ReviewInputTitle.Size = new System.Drawing.Size(272, 51);
            this.ReviewInputTitle.TabIndex = 5;
            this.ReviewInputTitle.Text = "Leave a Review";
            // 
            // txtOccupation
            // 
            this.txtOccupation.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtOccupation.Location = new System.Drawing.Point(526, 146);
            this.txtOccupation.Name = "txtOccupation";
            this.txtOccupation.Size = new System.Drawing.Size(183, 25);
            this.txtOccupation.TabIndex = 11;
            // 
            // OccupationLabel
            // 
            this.OccupationLabel.AutoSize = true;
            this.OccupationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.OccupationLabel.Location = new System.Drawing.Point(359, 149);
            this.OccupationLabel.Name = "OccupationLabel";
            this.OccupationLabel.Size = new System.Drawing.Size(161, 19);
            this.OccupationLabel.TabIndex = 15;
            this.OccupationLabel.Text = "What is your occupation:";
            // 
            // graduationDatePicker
            // 
            this.graduationDatePicker.CustomFormat = "yyyy";
            this.graduationDatePicker.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.graduationDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.graduationDatePicker.Location = new System.Drawing.Point(526, 239);
            this.graduationDatePicker.Name = "graduationDatePicker";
            this.graduationDatePicker.ShowUpDown = true;
            this.graduationDatePicker.Size = new System.Drawing.Size(66, 25);
            this.graduationDatePicker.TabIndex = 16;
            // 
            // GraduationLabel
            // 
            this.GraduationLabel.AutoSize = true;
            this.GraduationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.GraduationLabel.Location = new System.Drawing.Point(336, 241);
            this.GraduationLabel.Name = "GraduationLabel";
            this.GraduationLabel.Size = new System.Drawing.Size(184, 19);
            this.GraduationLabel.TabIndex = 17;
            this.GraduationLabel.Text = "What year did you graduate:";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(294, 519);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 17);
            this.ScoreLabel.TabIndex = 19;
            this.ScoreLabel.Text = "Your Score:";
            // 
            // ReviewScoreBar
            // 
            this.ReviewScoreBar.Location = new System.Drawing.Point(374, 519);
            this.ReviewScoreBar.Minimum = 1;
            this.ReviewScoreBar.Name = "ReviewScoreBar";
            this.ReviewScoreBar.Size = new System.Drawing.Size(335, 45);
            this.ReviewScoreBar.TabIndex = 18;
            this.ReviewScoreBar.Value = 1;
            // 
            // Incomelabel
            // 
            this.Incomelabel.AutoSize = true;
            this.Incomelabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Incomelabel.Location = new System.Drawing.Point(337, 211);
            this.Incomelabel.Name = "Incomelabel";
            this.Incomelabel.Size = new System.Drawing.Size(183, 19);
            this.Incomelabel.TabIndex = 21;
            this.Incomelabel.Text = "What is your annual income:";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIncome.Location = new System.Drawing.Point(526, 208);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(183, 25);
            this.txtIncome.TabIndex = 20;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CourseLabel.Location = new System.Drawing.Point(283, 273);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(237, 19);
            this.CourseLabel.TabIndex = 23;
            this.CourseLabel.Text = "In what course did you start working:";
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCourse.Location = new System.Drawing.Point(526, 270);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(183, 25);
            this.txtCourse.TabIndex = 22;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.durationLabel.Location = new System.Drawing.Point(184, 180);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(336, 19);
            this.durationLabel.TabIndex = 25;
            this.durationLabel.Text = "How long have you been working in your current job:";
            // 
            // txtDuration
            // 
            this.txtDuration.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDuration.Location = new System.Drawing.Point(526, 177);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(183, 25);
            this.txtDuration.TabIndex = 24;
            // 
            // StatsReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.durationLabel);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.txtCourse);
            this.Controls.Add(this.Incomelabel);
            this.Controls.Add(this.txtIncome);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ReviewScoreBar);
            this.Controls.Add(this.GraduationLabel);
            this.Controls.Add(this.graduationDatePicker);
            this.Controls.Add(this.OccupationLabel);
            this.Controls.Add(this.txtOccupation);
            this.Controls.Add(this.previousForm);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.ReviewInputTitle);
            this.Name = "StatsReviewView";
            this.Text = "StatsReviewView";
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel previousForm;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.RichTextBox ReviewTextBox;
        private System.Windows.Forms.Label ReviewInputTitle;
        private System.Windows.Forms.TextBox txtOccupation;
        private System.Windows.Forms.Label OccupationLabel;
        private System.Windows.Forms.DateTimePicker graduationDatePicker;
        private System.Windows.Forms.Label GraduationLabel;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.TrackBar ReviewScoreBar;
        private System.Windows.Forms.Label Incomelabel;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.Label durationLabel;
        private System.Windows.Forms.TextBox txtDuration;
    }
}