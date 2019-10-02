namespace Advisor.View
{
    partial class StudySubjectView
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
            this.leaveReviewButton = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.Reviews = new System.Windows.Forms.ListBox();
            this.SubjectTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaveReviewButton
            // 
            this.leaveReviewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leaveReviewButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.leaveReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leaveReviewButton.Location = new System.Drawing.Point(380, 614);
            this.leaveReviewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.leaveReviewButton.Name = "leaveReviewButton";
            this.leaveReviewButton.Size = new System.Drawing.Size(552, 46);
            this.leaveReviewButton.TabIndex = 9;
            this.leaveReviewButton.Text = "Leave a review";
            this.leaveReviewButton.UseVisualStyleBackColor = true;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(12, 9);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(24, 17);
            this.PreviousForm.TabIndex = 8;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // Reviews
            // 
            this.Reviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reviews.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Reviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reviews.FormattingEnabled = true;
            this.Reviews.ItemHeight = 28;
            this.Reviews.Location = new System.Drawing.Point(380, 234);
            this.Reviews.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(552, 312);
            this.Reviews.TabIndex = 7;
            // 
            // SubjectTitle
            // 
            this.SubjectTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SubjectTitle.AutoSize = true;
            this.SubjectTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.SubjectTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubjectTitle.Location = new System.Drawing.Point(496, 113);
            this.SubjectTitle.Name = "SubjectTitle";
            this.SubjectTitle.Size = new System.Drawing.Size(311, 62);
            this.SubjectTitle.TabIndex = 5;
            this.SubjectTitle.Text = "Study Subject";
            // 
            // StudySubjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 755);
            this.Controls.Add(this.leaveReviewButton);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.SubjectTitle);
            this.Name = "StudySubjectView";
            this.Text = "StudySubject";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClosed);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveReviewButton;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.ListBox Reviews;
        private System.Windows.Forms.Label SubjectTitle;
    }
}