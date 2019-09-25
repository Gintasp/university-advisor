namespace Advisor.View
{
    partial class IndividualFaculty
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
            this.FacultyTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutSection = new System.Windows.Forms.Label();
            this.StudyProgramList = new System.Windows.Forms.ListView();
            this.btnLecturers = new System.Windows.Forms.Button();
            this.btnAddStudyProgram = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitle
            // 
            this.FacultyTitle.AutoSize = true;
            this.FacultyTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitle.Location = new System.Drawing.Point(65, 50);
            this.FacultyTitle.MaximumSize = new System.Drawing.Size(500, 0);
            this.FacultyTitle.Name = "FacultyTitle";
            this.FacultyTitle.Size = new System.Drawing.Size(99, 54);
            this.FacultyTitle.TabIndex = 0;
            this.FacultyTitle.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(74, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "About";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(74, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 198);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(4, 4);
            this.AboutSection.MaximumSize = new System.Drawing.Size(310, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(79, 28);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // StudyProgramList
            // 
            this.StudyProgramList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramList.HideSelection = false;
            this.StudyProgramList.Location = new System.Drawing.Point(521, 69);
            this.StudyProgramList.Name = "StudyProgramList";
            this.StudyProgramList.Size = new System.Drawing.Size(289, 343);
            this.StudyProgramList.TabIndex = 3;
            this.StudyProgramList.UseCompatibleStateImageBehavior = false;
            // 
            // btnLecturers
            // 
            this.btnLecturers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLecturers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLecturers.Location = new System.Drawing.Point(74, 447);
            this.btnLecturers.Name = "btnLecturers";
            this.btnLecturers.Size = new System.Drawing.Size(337, 56);
            this.btnLecturers.TabIndex = 4;
            this.btnLecturers.Text = "Lecturers";
            this.btnLecturers.UseVisualStyleBackColor = true;
            this.btnLecturers.Click += new System.EventHandler(this.BtnLecturers_Click);
            // 
            // btnAddStudyProgram
            // 
            this.btnAddStudyProgram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudyProgram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudyProgram.Location = new System.Drawing.Point(521, 447);
            this.btnAddStudyProgram.Name = "btnAddStudyProgram";
            this.btnAddStudyProgram.Size = new System.Drawing.Size(289, 56);
            this.btnAddStudyProgram.TabIndex = 5;
            this.btnAddStudyProgram.Text = "Add Study Program";
            this.btnAddStudyProgram.UseVisualStyleBackColor = true;
            this.btnAddStudyProgram.Click += new System.EventHandler(this.BtnAddStudyProgram_Click);
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(13, 13);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(27, 20);
            this.PreviousForm.TabIndex = 6;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousForm_LinkClicked);
            // 
            // IndividualFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 569);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.btnAddStudyProgram);
            this.Controls.Add(this.btnLecturers);
            this.Controls.Add(this.StudyProgramList);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultyTitle);
            this.Name = "IndividualFaculty";
            this.Text = "IndividualFaculty";
            this.Load += new System.EventHandler(this.IndividualFaculty_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FacultyTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.ListView StudyProgramList;
        private System.Windows.Forms.Button btnLecturers;
        private System.Windows.Forms.Button btnAddStudyProgram;
        private System.Windows.Forms.LinkLabel PreviousForm;
    }
}