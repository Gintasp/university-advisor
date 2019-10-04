namespace Advisor.View
{
    partial class UniversityView
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UniversityTitleLabel = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AboutSection = new System.Windows.Forms.Label();
            this.PreviousIndividualUniversityView = new System.Windows.Forms.LinkLabel();
            this.FacultyListBox = new System.Windows.Forms.ListBox();
            this.AddFacultyLink = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UniversityTitleLabel
            // 
            this.UniversityTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniversityTitleLabel.AutoSize = true;
            this.UniversityTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversityTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityTitleLabel.Location = new System.Drawing.Point(94, 73);
            this.UniversityTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UniversityTitleLabel.MaximumSize = new System.Drawing.Size(200, 0);
            this.UniversityTitleLabel.Name = "UniversityTitleLabel";
            this.UniversityTitleLabel.Size = new System.Drawing.Size(74, 41);
            this.UniversityTitleLabel.TabIndex = 0;
            this.UniversityTitleLabel.Text = "Title";
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About.Location = new System.Drawing.Point(91, 256);
            this.About.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(52, 21);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(95, 279);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 181);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(2, 6);
            this.AboutSection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AboutSection.MaximumSize = new System.Drawing.Size(233, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(55, 19);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // PreviousIndividualUniversityView
            // 
            this.PreviousIndividualUniversityView.AutoSize = true;
            this.PreviousIndividualUniversityView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousIndividualUniversityView.Location = new System.Drawing.Point(9, 7);
            this.PreviousIndividualUniversityView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousIndividualUniversityView.Name = "PreviousIndividualUniversityView";
            this.PreviousIndividualUniversityView.Size = new System.Drawing.Size(24, 17);
            this.PreviousIndividualUniversityView.TabIndex = 6;
            this.PreviousIndividualUniversityView.TabStop = true;
            this.PreviousIndividualUniversityView.Text = "<<";
            this.PreviousIndividualUniversityView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // FacultyListBox
            // 
            this.FacultyListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultyListBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultyListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultyListBox.FormattingEnabled = true;
            this.FacultyListBox.ItemHeight = 20;
            this.FacultyListBox.Location = new System.Drawing.Point(443, 106);
            this.FacultyListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FacultyListBox.Name = "FacultyListBox";
            this.FacultyListBox.Size = new System.Drawing.Size(359, 344);
            this.FacultyListBox.TabIndex = 7;
            this.FacultyListBox.SelectedIndexChanged += new System.EventHandler(this.OnFacSelect);
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(440, 463);
            this.AddFacultyLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(190, 15);
            this.AddFacultyLink.TabIndex = 8;
            this.AddFacultyLink.TabStop = true;
            this.AddFacultyLink.Text = "Cant find your Faculty? Add it here";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(438, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Faculties";
            // 
            // UniversityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFacultyLink);
            this.Controls.Add(this.FacultyListBox);
            this.Controls.Add(this.PreviousIndividualUniversityView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.UniversityTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UniversityView";
            this.Text = "University";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.LoadUniversityData);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label UniversityTitleLabel;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel PreviousIndividualUniversityView;
        private System.Windows.Forms.Label AboutSection;
        private System.Windows.Forms.ListBox FacultyListBox;
        private System.Windows.Forms.LinkLabel AddFacultyLink;
        private System.Windows.Forms.Label label1;
    }
}