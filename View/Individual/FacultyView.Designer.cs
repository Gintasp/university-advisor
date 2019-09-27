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
            this.StudyProgramList = new System.Windows.Forms.ListView();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnAddStudyProgram = new System.Windows.Forms.Button();
            this.PreviousIndividualFaculty = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitleLabel
            // 
            this.FacultyTitleLabel.AutoSize = true;
            this.FacultyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitleLabel.Location = new System.Drawing.Point(58, 40);
            this.FacultyTitleLabel.MaximumSize = new System.Drawing.Size(444, 0);
            this.FacultyTitleLabel.Name = "FacultyTitleLabel";
            this.FacultyTitleLabel.Size = new System.Drawing.Size(84, 46);
            this.FacultyTitleLabel.TabIndex = 0;
            this.FacultyTitleLabel.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(66, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "About";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(66, 171);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 159);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(4, 3);
            this.AboutSection.MaximumSize = new System.Drawing.Size(276, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(67, 23);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // StudyProgramList
            // 
            this.StudyProgramList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramList.HideSelection = false;
            this.StudyProgramList.Location = new System.Drawing.Point(463, 55);
            this.StudyProgramList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudyProgramList.Name = "StudyProgramList";
            this.StudyProgramList.Size = new System.Drawing.Size(257, 275);
            this.StudyProgramList.TabIndex = 3;
            this.StudyProgramList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLecturers
            // 
            this.btnLecturers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLecturers.Location = new System.Drawing.Point(66, 358);
            this.btnLecturers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(300, 45);
            this.btnLecturers.TabIndex = 4;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.OnLecturersButtonClick);
            // 
            // btnAddStudyProgram
            // 
            this.btnAddStudyProgram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudyProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudyProgram.Location = new System.Drawing.Point(463, 358);
            this.btnAddStudyProgram.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudyProgram.Name = "btnAddStudyProgram";
            this.btnAddStudyProgram.Size = new System.Drawing.Size(257, 45);
            this.btnAddStudyProgram.TabIndex = 5;
            this.btnAddStudyProgram.Text = "Add Study Program";
            this.btnAddStudyProgram.UseVisualStyleBackColor = true;
            this.btnAddStudyProgram.Click += new System.EventHandler(this.OnAddStudyProgramButtonClick);
            // 
            // PreviousIndividualFaculty
            // 
            this.PreviousIndividualFaculty.AutoSize = true;
            this.PreviousIndividualFaculty.Location = new System.Drawing.Point(12, 10);
            this.PreviousIndividualFaculty.Name = "PreviousIndividualFaculty";
            this.PreviousIndividualFaculty.Size = new System.Drawing.Size(24, 17);
            this.PreviousIndividualFaculty.TabIndex = 6;
            this.PreviousIndividualFaculty.TabStop = true;
            this.PreviousIndividualFaculty.Text = "<<";
            this.PreviousIndividualFaculty.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 455);
            this.Controls.Add(this.PreviousIndividualFaculty);
            this.Controls.Add(this.btnAddStudyProgram);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.StudyProgramList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FacultyView";
            this.Text = "IndividualFaculty";
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
        private System.Windows.Forms.ListView StudyProgramList;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnAddStudyProgram;
        private System.Windows.Forms.LinkLabel PreviousIndividualFaculty;
    }
}