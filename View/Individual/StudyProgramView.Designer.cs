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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutSection = new System.Windows.Forms.Label();
            this.btnLeaveAReview = new System.Windows.Forms.Button();
            this.ReviewData = new System.Windows.Forms.ListBox();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.CourseData = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddFacultyLink = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.Satisfaction = new System.Windows.Forms.Label();
            this.Overal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleLabel.Location = new System.Drawing.Point(184, 68);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.MaximumSize = new System.Drawing.Size(267, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(93, 51);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(192, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
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
            this.panel1.Location = new System.Drawing.Point(193, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 184);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(2, 0);
            this.AboutSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AboutSection.MaximumSize = new System.Drawing.Size(193, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(55, 19);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // btnLeaveAReview
            // 
            this.btnLeaveAReview.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeaveAReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveAReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLeaveAReview.Location = new System.Drawing.Point(186, 567);
            this.btnLeaveAReview.Margin = new System.Windows.Forms.Padding(2);
            this.btnLeaveAReview.Name = "btnLeaveAReview";
            this.btnLeaveAReview.Size = new System.Drawing.Size(287, 36);
            this.btnLeaveAReview.TabIndex = 3;
            this.btnLeaveAReview.Text = "Leave a review";
            this.btnLeaveAReview.UseVisualStyleBackColor = true;
            this.btnLeaveAReview.Click += new System.EventHandler(this.OnLeaveReviewButtonClick);
            // 
            // ReviewData
            // 
            this.ReviewData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReviewData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewData.FormattingEnabled = true;
            this.ReviewData.ItemHeight = 17;
            this.ReviewData.Location = new System.Drawing.Point(843, 204);
            this.ReviewData.Margin = new System.Windows.Forms.Padding(2);
            this.ReviewData.Name = "ReviewData";
            this.ReviewData.Size = new System.Drawing.Size(325, 344);
            this.ReviewData.TabIndex = 5;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousForm.Location = new System.Drawing.Point(8, 6);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(24, 17);
            this.PreviousForm.TabIndex = 6;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(837, 165);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Reviews";
            // 
            // CourseData
            // 
            this.CourseData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseData.FormattingEnabled = true;
            this.CourseData.ItemHeight = 17;
            this.CourseData.Location = new System.Drawing.Point(500, 204);
            this.CourseData.Margin = new System.Windows.Forms.Padding(2);
            this.CourseData.Name = "CourseData";
            this.CourseData.Size = new System.Drawing.Size(325, 344);
            this.CourseData.TabIndex = 8;
            this.CourseData.SelectedIndexChanged += new System.EventHandler(this.OnCourseSelect);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(493, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 37);
            this.label3.TabIndex = 9;
            this.label3.Text = "Courses";
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(500, 556);
            this.AddFacultyLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(187, 15);
            this.AddFacultyLink.TabIndex = 10;
            this.AddFacultyLink.TabStop = true;
            this.AddFacultyLink.Text = "Cant find your course? Add it here";
            this.AddFacultyLink.Click += new System.EventHandler(this.OnAddCourseLinkClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Overal);
            this.groupBox1.Controls.Add(this.Satisfaction);
            this.groupBox1.Controls.Add(this.Difficulty);
            this.groupBox1.Controls.Add(this.Salary);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(193, 393);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 154);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Avg. graduate salary:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Difficulty:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Satisfaction:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(12, 115);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Overal rating";
            // 
            // Salary
            // 
            this.Salary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Salary.Location = new System.Drawing.Point(145, 33);
            this.Salary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(14, 15);
            this.Salary.TabIndex = 16;
            this.Salary.Text = "X";
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Difficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Difficulty.Location = new System.Drawing.Point(87, 61);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(14, 15);
            this.Difficulty.TabIndex = 17;
            this.Difficulty.Text = "X";
            // 
            // Satisfaction
            // 
            this.Satisfaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Satisfaction.AutoSize = true;
            this.Satisfaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Satisfaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Satisfaction.Location = new System.Drawing.Point(97, 88);
            this.Satisfaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Satisfaction.Name = "Satisfaction";
            this.Satisfaction.Size = new System.Drawing.Size(14, 15);
            this.Satisfaction.TabIndex = 18;
            this.Satisfaction.Text = "X";
            // 
            // Overal
            // 
            this.Overal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Overal.AutoSize = true;
            this.Overal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Overal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Overal.Location = new System.Drawing.Point(103, 115);
            this.Overal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Overal.Name = "Overal";
            this.Overal.Size = new System.Drawing.Size(14, 15);
            this.Overal.TabIndex = 19;
            this.Overal.Text = "X";
            // 
            // StudyProgramView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1313, 675);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.AddFacultyLink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CourseData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.ReviewData);
            this.Controls.Add(this.btnLeaveAReview);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudyProgramView";
            this.Text = "Study Program";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLeaveAReview;
        private System.Windows.Forms.ListBox ReviewData;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CourseData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel AddFacultyLink;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Overal;
        private System.Windows.Forms.Label Satisfaction;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}