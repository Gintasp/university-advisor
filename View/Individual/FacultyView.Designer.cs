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
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnAddStudyProgram = new System.Windows.Forms.Button();
            this.PreviousIndividualFaculty = new System.Windows.Forms.LinkLabel();
            this.StudyProgramList = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitleLabel
            // 
            this.FacultyTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultyTitleLabel.AutoSize = true;
            this.FacultyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitleLabel.Location = new System.Drawing.Point(114, 151);
            this.FacultyTitleLabel.MaximumSize = new System.Drawing.Size(500, 0);
            this.FacultyTitleLabel.Name = "FacultyTitleLabel";
            this.FacultyTitleLabel.Size = new System.Drawing.Size(108, 60);
            this.FacultyTitleLabel.TabIndex = 0;
            this.FacultyTitleLabel.Text = "Title";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(118, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(124, 380);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 325);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(4, 3);
            this.AboutSection.MaximumSize = new System.Drawing.Size(310, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(79, 28);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // btnLecturers
            // 
            this.btnLecturers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLecturers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLecturers.Location = new System.Drawing.Point(124, 745);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(505, 57);
            this.btnLecturers.TabIndex = 4;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.OnLecturersButtonClick);
            // 
            // btnAddStudyProgram
            // 
            this.btnAddStudyProgram.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudyProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudyProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudyProgram.Location = new System.Drawing.Point(682, 745);
            this.btnAddStudyProgram.Name = "btnAddStudyProgram";
            this.btnAddStudyProgram.Size = new System.Drawing.Size(679, 57);
            this.btnAddStudyProgram.TabIndex = 5;
            this.btnAddStudyProgram.Text = "Add Study Program";
            this.btnAddStudyProgram.UseVisualStyleBackColor = true;
            this.btnAddStudyProgram.Click += new System.EventHandler(this.OnAddStudyProgramButtonClick);
            // 
            // PreviousIndividualFaculty
            // 
            this.PreviousIndividualFaculty.AutoSize = true;
            this.PreviousIndividualFaculty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousIndividualFaculty.Location = new System.Drawing.Point(12, 9);
            this.PreviousIndividualFaculty.Name = "PreviousIndividualFaculty";
            this.PreviousIndividualFaculty.Size = new System.Drawing.Size(36, 25);
            this.PreviousIndividualFaculty.TabIndex = 6;
            this.PreviousIndividualFaculty.TabStop = true;
            this.PreviousIndividualFaculty.Text = "<<";
            this.PreviousIndividualFaculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // StudyProgramList
            // 
            this.StudyProgramList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudyProgramList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramList.FormattingEnabled = true;
            this.StudyProgramList.ItemHeight = 32;
            this.StudyProgramList.Location = new System.Drawing.Point(682, 221);
            this.StudyProgramList.Margin = new System.Windows.Forms.Padding(10);
            this.StudyProgramList.Name = "StudyProgramList";
            this.StudyProgramList.Size = new System.Drawing.Size(679, 484);
            this.StudyProgramList.TabIndex = 7;
            this.StudyProgramList.SelectedIndexChanged += new System.EventHandler(this.onStudyProgramSelect);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(673, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 45);
            this.label2.TabIndex = 8;
            this.label2.Text = "Study Programs";
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.StudyProgramList);
            this.Controls.Add(this.PreviousIndividualFaculty);
            this.Controls.Add(this.btnAddStudyProgram);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyTitleLabel);
            this.Name = "FacultyView";
            this.Text = "Faculty";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
            this.Load += new System.EventHandler(this.OnFacultyLoad);
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
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnAddStudyProgram;
        private System.Windows.Forms.LinkLabel PreviousIndividualFaculty;
        private System.Windows.Forms.ListBox StudyProgramList;
        private System.Windows.Forms.Label label2;
    }
}