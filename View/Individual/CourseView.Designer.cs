namespace Advisor.View
{
    partial class CourseView
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
            this.CourseTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // leaveReviewButton
            // 
            this.leaveReviewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leaveReviewButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.leaveReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leaveReviewButton.Location = new System.Drawing.Point(285, 499);
            this.leaveReviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.leaveReviewButton.Name = "leaveReviewButton";
            this.leaveReviewButton.Size = new System.Drawing.Size(414, 37);
            this.leaveReviewButton.TabIndex = 9;
            this.leaveReviewButton.Text = "Leave a review";
            this.leaveReviewButton.UseVisualStyleBackColor = true;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(9, 7);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(19, 13);
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
            this.Reviews.ItemHeight = 21;
            this.Reviews.Location = new System.Drawing.Point(285, 190);
            this.Reviews.Margin = new System.Windows.Forms.Padding(2);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(415, 235);
            this.Reviews.TabIndex = 7;
            // 
            // CourseTitle
            // 
            this.CourseTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.CourseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseTitle.Location = new System.Drawing.Point(285, 105);
            this.CourseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.Size = new System.Drawing.Size(414, 51);
            this.CourseTitle.TabIndex = 5;
            this.CourseTitle.Text = "Course";
            this.CourseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 609);
            this.Controls.Add(this.leaveReviewButton);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.Reviews);
            this.Controls.Add(this.CourseTitle);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseView";
            this.Text = "Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveReviewButton;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.ListBox Reviews;
        private System.Windows.Forms.Label CourseTitle;
    }
}