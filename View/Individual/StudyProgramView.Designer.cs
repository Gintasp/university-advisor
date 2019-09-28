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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudyProgramTitle
            // 
            this.StudyProgramTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudyProgramTitle.AutoSize = true;
            this.StudyProgramTitle.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramTitle.Location = new System.Drawing.Point(57, 117);
            this.StudyProgramTitle.MaximumSize = new System.Drawing.Size(400, 0);
            this.StudyProgramTitle.Name = "StudyProgramTitle";
            this.StudyProgramTitle.Size = new System.Drawing.Size(137, 74);
            this.StudyProgramTitle.TabIndex = 0;
            this.StudyProgramTitle.Text = "Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(64, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Location = new System.Drawing.Point(70, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(431, 316);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(3, 0);
            this.AboutSection.MaximumSize = new System.Drawing.Size(290, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(79, 28);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // btnLeaveAReview
            // 
            this.btnLeaveAReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaveAReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveAReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLeaveAReview.Location = new System.Drawing.Point(70, 701);
            this.btnLeaveAReview.Name = "btnLeaveAReview";
            this.btnLeaveAReview.Size = new System.Drawing.Size(431, 55);
            this.btnLeaveAReview.TabIndex = 3;
            this.btnLeaveAReview.Text = "Leave a review";
            this.btnLeaveAReview.UseVisualStyleBackColor = true;
            this.btnLeaveAReview.Click += new System.EventHandler(this.OnLeaveReviewButtonClick);
            // 
            // btnStudySubjects
            // 
            this.btnStudySubjects.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStudySubjects.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudySubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStudySubjects.Location = new System.Drawing.Point(70, 772);
            this.btnStudySubjects.Name = "btnStudySubjects";
            this.btnStudySubjects.Size = new System.Drawing.Size(431, 55);
            this.btnStudySubjects.TabIndex = 4;
            this.btnStudySubjects.Text = "Study subjects";
            this.btnStudySubjects.UseVisualStyleBackColor = true;
            this.btnStudySubjects.Click += new System.EventHandler(this.OnStudySubjectsButtonClick);
            // 
            // ReviewList
            // 
            this.ReviewList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReviewList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewList.FormattingEnabled = true;
            this.ReviewList.ItemHeight = 28;
            this.ReviewList.Location = new System.Drawing.Point(550, 203);
            this.ReviewList.Name = "ReviewList";
            this.ReviewList.Size = new System.Drawing.Size(872, 620);
            this.ReviewList.TabIndex = 5;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousForm.Location = new System.Drawing.Point(12, 9);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(36, 25);
            this.PreviousForm.TabIndex = 6;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(541, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 54);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reviews";
            // 
            // StudyProgramView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.ReviewList);
            this.Controls.Add(this.btnStudySubjects);
            this.Controls.Add(this.btnLeaveAReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudyProgramTitle);
            this.Name = "StudyProgramView";
            this.Text = "Study Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
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
        private System.Windows.Forms.Label label1;
    }
}