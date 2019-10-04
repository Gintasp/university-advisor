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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FacultyTitleLabel
            // 
            this.FacultyTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultyTitleLabel.AutoSize = true;
            this.FacultyTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyTitleLabel.Location = new System.Drawing.Point(158, 90);
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
            this.label1.Location = new System.Drawing.Point(153, 192);
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
            this.panel1.Location = new System.Drawing.Point(157, 215);
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
            this.label2.Location = new System.Drawing.Point(546, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Study Programs";
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(548, 509);
            this.AddFacultyLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(230, 15);
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
            this.label3.Location = new System.Drawing.Point(849, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lecturers";
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(851, 509);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(125, 15);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Add your lecturer here";
            this.linkLabel1.Click += new System.EventHandler(this.OnAddLecturerLinkClick);
            // 
            // FacultyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 614);
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
        private System.Windows.Forms.ListBox StudyProgramListBox;
        private System.Windows.Forms.ListBox LecturerListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel AddFacultyLink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}