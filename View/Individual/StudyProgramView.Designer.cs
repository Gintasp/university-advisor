namespace Advisor.View
{
    partial class StudyProgramView
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
            this.StudyProgramTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutSection = new System.Windows.Forms.Label();
            this.btnLeaveAReview = new System.Windows.Forms.Button();
            this.btnStudySubjects = new System.Windows.Forms.Button();
            this.ReviewList = new System.Windows.Forms.ListBox();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudyProgramTitle
            // 
            this.StudyProgramTitle.AutoSize = true;
            this.StudyProgramTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramTitle.Location = new System.Drawing.Point(34, 31);
            this.StudyProgramTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StudyProgramTitle.MaximumSize = new System.Drawing.Size(267, 0);
            this.StudyProgramTitle.Name = "StudyProgramTitle";
            this.StudyProgramTitle.Size = new System.Drawing.Size(68, 37);
            this.StudyProgramTitle.TabIndex = 0;
            this.StudyProgramTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(37, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "About";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(40, 120);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 150);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(3, 3);
            this.AboutSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AboutSection.MaximumSize = new System.Drawing.Size(193, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(45, 13);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // btnLeaveAReview
            // 
            this.btnLeaveAReview.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveAReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLeaveAReview.Location = new System.Drawing.Point(40, 282);
            this.btnLeaveAReview.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLeaveAReview.Name = "btnLeaveAReview";
            this.btnLeaveAReview.Size = new System.Drawing.Size(219, 36);
            this.btnLeaveAReview.TabIndex = 3;
            this.btnLeaveAReview.Text = "Leave a review";
            this.btnLeaveAReview.UseVisualStyleBackColor = true;
            this.btnLeaveAReview.Click += new System.EventHandler(this.OnLeaveReviewButtonClick);
            // 
            // btnStudySubjects
            // 
            this.btnStudySubjects.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudySubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudySubjects.Location = new System.Drawing.Point(40, 328);
            this.btnStudySubjects.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnStudySubjects.Name = "btnStudySubjects";
            this.btnStudySubjects.Size = new System.Drawing.Size(219, 36);
            this.btnStudySubjects.TabIndex = 4;
            this.btnStudySubjects.Text = "Study subjects";
            this.btnStudySubjects.UseVisualStyleBackColor = true;
            this.btnStudySubjects.Click += new System.EventHandler(this.OnStudySubjectsButtonClick);
            // 
            // ReviewList
            // 
            this.ReviewList.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewList.FormattingEnabled = true;
            this.ReviewList.ItemHeight = 15;
            this.ReviewList.Location = new System.Drawing.Point(309, 47);
            this.ReviewList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReviewList.Name = "ReviewList";
            this.ReviewList.Size = new System.Drawing.Size(282, 304);
            this.ReviewList.TabIndex = 5;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(8, 6);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(19, 13);
            this.PreviousForm.TabIndex = 6;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // StudyProgramView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.ReviewList);
            this.Controls.Add(this.btnStudySubjects);
            this.Controls.Add(this.btnLeaveAReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudyProgramTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StudyProgramView";
            this.Text = "Study Program";
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StudyProgramTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLeaveAReview;
        private System.Windows.Forms.Button btnStudySubjects;
        private System.Windows.Forms.ListBox ReviewList;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.LinkLabel PreviousForm;
    }
}