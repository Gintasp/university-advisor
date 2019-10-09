namespace Advisor.View
{
    partial class FacultyView
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
            this.FacultyTitleLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutSection = new System.Windows.Forms.Label();
            this.PreviousIndividualFaculty = new System.Windows.Forms.LinkLabel();
            this.StudyProgramListBox = new System.Windows.Forms.ListBox();
            this.LecturerListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddFacultyLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OveralVal = new System.Windows.Forms.Label();
            this.SatisfactionVal = new System.Windows.Forms.Label();
            this.DifficultyVal = new System.Windows.Forms.Label();
            this.SalaryVal = new System.Windows.Forms.Label();
            this.FacOveral = new System.Windows.Forms.Label();
            this.FacSatisfaction = new System.Windows.Forms.Label();
            this.FacDifficulty = new System.Windows.Forms.Label();
            this.FacSalary = new System.Windows.Forms.Label();
            this.CompareLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitleLabel
            // 
            this.FacultyTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitleLabel.Location = new System.Drawing.Point(236, 38);
            this.FacultyTitleLabel.Name = "FacultyTitleLabel";
            this.FacultyTitleLabel.Size = new System.Drawing.Size(884, 58);
            this.FacultyTitleLabel.TabIndex = 0;
            this.FacultyTitleLabel.Text = "Title";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(240, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(245, 199);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 188);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(4, 2);
            this.AboutSection.MaximumSize = new System.Drawing.Size(276, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(67, 23);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // PreviousIndividualFaculty
            // 
            this.PreviousIndividualFaculty.AutoSize = true;
            this.PreviousIndividualFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousIndividualFaculty.Location = new System.Drawing.Point(11, 7);
            this.PreviousIndividualFaculty.Name = "PreviousIndividualFaculty";
            this.PreviousIndividualFaculty.Size = new System.Drawing.Size(29, 20);
            this.PreviousIndividualFaculty.TabIndex = 6;
            this.PreviousIndividualFaculty.TabStop = true;
            this.PreviousIndividualFaculty.Text = "<<";
            this.PreviousIndividualFaculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // StudyProgramListBox
            // 
            this.StudyProgramListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudyProgramListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramListBox.FormattingEnabled = true;
            this.StudyProgramListBox.ItemHeight = 28;
            this.StudyProgramListBox.Location = new System.Drawing.Point(735, 199);
            this.StudyProgramListBox.Margin = new System.Windows.Forms.Padding(0);
            this.StudyProgramListBox.Name = "StudyProgramListBox";
            this.StudyProgramListBox.Size = new System.Drawing.Size(384, 396);
            this.StudyProgramListBox.TabIndex = 7;
            this.StudyProgramListBox.SelectedIndexChanged += new System.EventHandler(this.OnStudyProgramSelect);
            // 
            // LecturerListBox
            // 
            this.LecturerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LecturerListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LecturerListBox.FormattingEnabled = true;
            this.LecturerListBox.ItemHeight = 28;
            this.LecturerListBox.Location = new System.Drawing.Point(1139, 199);
            this.LecturerListBox.Margin = new System.Windows.Forms.Padding(0);
            this.LecturerListBox.Name = "LecturerListBox";
            this.LecturerListBox.Size = new System.Drawing.Size(384, 396);
            this.LecturerListBox.TabIndex = 9;
            this.LecturerListBox.SelectedIndexChanged += new System.EventHandler(this.OnLecturerSelect);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(728, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 37);
            this.label2.TabIndex = 8;
            this.label2.Text = "Study Programs";
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(731, 626);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(288, 20);
            this.AddFacultyLink.TabIndex = 9;
            this.AddFacultyLink.TabStop = true;
            this.AddFacultyLink.Text = "Cant find your study program? Add it here";
            this.AddFacultyLink.Click += new System.EventHandler(this.OnAddStudyProgramLinkClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1132, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 37);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lecturers";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(1135, 626);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 20);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add your lecturer here";
            this.linkLabel1.Click += new System.EventHandler(this.OnAddLecturerLinkClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.OveralVal);
            this.groupBox1.Controls.Add(this.SatisfactionVal);
            this.groupBox1.Controls.Add(this.DifficultyVal);
            this.groupBox1.Controls.Add(this.SalaryVal);
            this.groupBox1.Controls.Add(this.FacOveral);
            this.groupBox1.Controls.Add(this.FacSatisfaction);
            this.groupBox1.Controls.Add(this.FacDifficulty);
            this.groupBox1.Controls.Add(this.FacSalary);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(245, 406);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(449, 212);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // OveralVal
            // 
            this.OveralVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OveralVal.AutoSize = true;
            this.OveralVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OveralVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OveralVal.Location = new System.Drawing.Point(141, 153);
            this.OveralVal.Name = "OveralVal";
            this.OveralVal.Size = new System.Drawing.Size(18, 20);
            this.OveralVal.TabIndex = 19;
            this.OveralVal.Text = "X";
            // 
            // SatisfactionVal
            // 
            this.SatisfactionVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SatisfactionVal.AutoSize = true;
            this.SatisfactionVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SatisfactionVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SatisfactionVal.Location = new System.Drawing.Point(141, 117);
            this.SatisfactionVal.Name = "SatisfactionVal";
            this.SatisfactionVal.Size = new System.Drawing.Size(18, 20);
            this.SatisfactionVal.TabIndex = 18;
            this.SatisfactionVal.Text = "X";
            // 
            // DifficultyVal
            // 
            this.DifficultyVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DifficultyVal.AutoSize = true;
            this.DifficultyVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DifficultyVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DifficultyVal.Location = new System.Drawing.Point(125, 81);
            this.DifficultyVal.Name = "DifficultyVal";
            this.DifficultyVal.Size = new System.Drawing.Size(18, 20);
            this.DifficultyVal.TabIndex = 17;
            this.DifficultyVal.Text = "X";
            // 
            // SalaryVal
            // 
            this.SalaryVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalaryVal.AutoSize = true;
            this.SalaryVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaryVal.Location = new System.Drawing.Point(204, 43);
            this.SalaryVal.Name = "SalaryVal";
            this.SalaryVal.Size = new System.Drawing.Size(18, 20);
            this.SalaryVal.TabIndex = 16;
            this.SalaryVal.Text = "X";
            // 
            // FacOveral
            // 
            this.FacOveral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacOveral.AutoSize = true;
            this.FacOveral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacOveral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacOveral.Location = new System.Drawing.Point(28, 153);
            this.FacOveral.Name = "FacOveral";
            this.FacOveral.Size = new System.Drawing.Size(98, 20);
            this.FacOveral.TabIndex = 15;
            this.FacOveral.Text = "Overal rating:";
            // 
            // FacSatisfaction
            // 
            this.FacSatisfaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacSatisfaction.AutoSize = true;
            this.FacSatisfaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacSatisfaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacSatisfaction.Location = new System.Drawing.Point(28, 117);
            this.FacSatisfaction.Name = "FacSatisfaction";
            this.FacSatisfaction.Size = new System.Drawing.Size(89, 20);
            this.FacSatisfaction.TabIndex = 14;
            this.FacSatisfaction.Text = "Satisfaction:";
            // 
            // FacDifficulty
            // 
            this.FacDifficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacDifficulty.AutoSize = true;
            this.FacDifficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacDifficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacDifficulty.Location = new System.Drawing.Point(28, 81);
            this.FacDifficulty.Name = "FacDifficulty";
            this.FacDifficulty.Size = new System.Drawing.Size(72, 20);
            this.FacDifficulty.TabIndex = 13;
            this.FacDifficulty.Text = "Difficulty:";
            // 
            // FacSalary
            // 
            this.FacSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacSalary.AutoSize = true;
            this.FacSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacSalary.Location = new System.Drawing.Point(28, 43);
            this.FacSalary.Name = "FacSalary";
            this.FacSalary.Size = new System.Drawing.Size(147, 20);
            this.FacSalary.TabIndex = 12;
            this.FacSalary.Text = "Avg. graduate salary:";
            // 
            // CompareLink
            // 
            this.CompareLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CompareLink.AutoSize = true;
            this.CompareLink.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CompareLink.Location = new System.Drawing.Point(241, 626);
            this.CompareLink.Name = "CompareLink";
            this.CompareLink.Size = new System.Drawing.Size(168, 28);
            this.CompareLink.TabIndex = 13;
            this.CompareLink.TabStop = true;
            this.CompareLink.Text = "Compare faculties";
            this.CompareLink.Click += new System.EventHandler(this.OnCompareLinkClick);
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 756);
            this.Controls.Add(this.CompareLink);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.AddFacultyLink);
            this.Controls.Add(this.LecturerListBox);
            this.Controls.Add(this.StudyProgramListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousIndividualFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FacultyView";
            this.Text = "Faculty";
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

        private System.Windows.Forms.Label FacultyTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.LinkLabel PreviousIndividualFaculty;
        private System.Windows.Forms.ListBox StudyProgramListBox;
        private System.Windows.Forms.ListBox LecturerListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel AddFacultyLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OveralVal;
        private System.Windows.Forms.Label SatisfactionVal;
        private System.Windows.Forms.Label DifficultyVal;
        private System.Windows.Forms.Label SalaryVal;
        private System.Windows.Forms.Label FacOveral;
        private System.Windows.Forms.Label FacSatisfaction;
        private System.Windows.Forms.Label FacDifficulty;
        private System.Windows.Forms.Label FacSalary;
        private System.Windows.Forms.LinkLabel CompareLink;
    }
}