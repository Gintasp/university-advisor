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
            this.btnAddStudyProgram = new System.Windows.Forms.Button();
            this.StudyProgramListBox = new System.Windows.Forms.ListBox();
            this.LecturerListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitleLabel
            // 
            this.FacultyTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultyTitleLabel.AutoSize = true;
            this.FacultyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitleLabel.Location = new System.Drawing.Point(178, 94);
            this.FacultyTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FacultyTitleLabel.MaximumSize = new System.Drawing.Size(333, 0);
            this.FacultyTitleLabel.Name = "FacultyTitleLabel";
            this.FacultyTitleLabel.Size = new System.Drawing.Size(74, 41);
            this.FacultyTitleLabel.TabIndex = 0;
            this.FacultyTitleLabel.Text = "Title";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(173, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(177, 238);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 309);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(3, 2);
            this.AboutSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AboutSection.MaximumSize = new System.Drawing.Size(207, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(55, 19);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // PreviousIndividualFaculty
            // 
            this.PreviousIndividualFaculty.AutoSize = true;
            this.PreviousIndividualFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousIndividualFaculty.Location = new System.Drawing.Point(8, 6);
            this.PreviousIndividualFaculty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousIndividualFaculty.Name = "PreviousIndividualFaculty";
            this.PreviousIndividualFaculty.Size = new System.Drawing.Size(24, 17);
            this.PreviousIndividualFaculty.TabIndex = 6;
            this.PreviousIndividualFaculty.TabStop = true;
            this.PreviousIndividualFaculty.Text = "<<";
            this.PreviousIndividualFaculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // btnAddStudyProgram
            // 
            this.btnAddStudyProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudyProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudyProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudyProgram.Location = new System.Drawing.Point(551, 510);
            this.btnAddStudyProgram.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddStudyProgram.Name = "btnAddStudyProgram";
            this.btnAddStudyProgram.Size = new System.Drawing.Size(289, 37);
            this.btnAddStudyProgram.TabIndex = 5;
            this.btnAddStudyProgram.Text = "Add Study Program";
            this.btnAddStudyProgram.UseVisualStyleBackColor = true;
            this.btnAddStudyProgram.Click += new System.EventHandler(this.OnAddStudyProgramButtonClick);
            // 
            // StudyProgramListBox
            // 
            this.StudyProgramListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudyProgramListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramListBox.FormattingEnabled = true;
            this.StudyProgramListBox.ItemHeight = 21;
            this.StudyProgramListBox.Location = new System.Drawing.Point(551, 162);
            this.StudyProgramListBox.Margin = new System.Windows.Forms.Padding(0);
            this.StudyProgramListBox.Name = "StudyProgramListBox";
            this.StudyProgramListBox.Size = new System.Drawing.Size(289, 340);
            this.StudyProgramListBox.TabIndex = 7;
            this.StudyProgramListBox.SelectedIndexChanged += new System.EventHandler(this.OnStudyProgramSelect);
            // 
            // LecturerListBox
            // 
            this.LecturerListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LecturerListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LecturerListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LecturerListBox.FormattingEnabled = true;
            this.LecturerListBox.ItemHeight = 21;
            this.LecturerListBox.Location = new System.Drawing.Point(854, 162);
            this.LecturerListBox.Margin = new System.Windows.Forms.Padding(0);
            this.LecturerListBox.Name = "LecturerListBox";
            this.LecturerListBox.Size = new System.Drawing.Size(289, 340);
            this.LecturerListBox.TabIndex = 9;
            this.LecturerListBox.SelectedIndexChanged += new System.EventHandler(this.OnLecturerSelect);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(556, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Study Programs";
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddLecturer.AutoSize = true;
            this.btnAddLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddLecturer.Location = new System.Drawing.Point(854, 510);
            this.btnAddLecturer.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(289, 37);
            this.btnAddLecturer.TabIndex = 5;
            this.btnAddLecturer.Text = "Add a lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.OnAddLecturerButtonClick);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(849, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lecturers";
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 614);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.LecturerListBox);
            this.Controls.Add(this.StudyProgramListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PreviousIndividualFaculty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddStudyProgram);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FacultyView";
            this.Text = "Faculty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacultyTitleLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.LinkLabel PreviousIndividualFaculty;
        private System.Windows.Forms.Button btnAddStudyProgram;
        private System.Windows.Forms.ListBox StudyProgramListBox;
        private System.Windows.Forms.ListBox LecturerListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddLecturer;
        private System.Windows.Forms.Label label3;
    }
}