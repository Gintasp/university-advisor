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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FacultiesVal = new System.Windows.Forms.Label();
            this.OveralVal = new System.Windows.Forms.Label();
            this.ReviewsVal = new System.Windows.Forms.Label();
            this.SalaryVal = new System.Windows.Forms.Label();
            this.UniOveral = new System.Windows.Forms.Label();
            this.UniReviews = new System.Windows.Forms.Label();
            this.UniFaculties = new System.Windows.Forms.Label();
            this.UniSalary = new System.Windows.Forms.Label();
            this.btnCompare = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.UniversityTitleLabel.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversityTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityTitleLabel.Location = new System.Drawing.Point(231, 114);
            this.UniversityTitleLabel.Name = "UniversityTitleLabel";
            this.UniversityTitleLabel.Size = new System.Drawing.Size(1017, 66);
            this.UniversityTitleLabel.TabIndex = 0;
            this.UniversityTitleLabel.Text = "Title";
            // 
            // About
            // 
            this.About.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About.Location = new System.Drawing.Point(235, 228);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(80, 32);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.AboutSection);
            this.panel1.Location = new System.Drawing.Point(241, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(366, 277);
            this.panel1.TabIndex = 2;
            // 
            // AboutSection
            // 
            this.AboutSection.AutoSize = true;
            this.AboutSection.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutSection.Location = new System.Drawing.Point(3, 9);
            this.AboutSection.MaximumSize = new System.Drawing.Size(350, 0);
            this.AboutSection.Name = "AboutSection";
            this.AboutSection.Size = new System.Drawing.Size(79, 28);
            this.AboutSection.TabIndex = 0;
            this.AboutSection.Text = "[About]";
            // 
            // PreviousIndividualUniversityView
            // 
            this.PreviousIndividualUniversityView.AutoSize = true;
            this.PreviousIndividualUniversityView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousIndividualUniversityView.Location = new System.Drawing.Point(14, 11);
            this.PreviousIndividualUniversityView.Name = "PreviousIndividualUniversityView";
            this.PreviousIndividualUniversityView.Size = new System.Drawing.Size(36, 25);
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
            this.FacultyListBox.ItemHeight = 30;
            this.FacultyListBox.Location = new System.Drawing.Point(710, 263);
            this.FacultyListBox.Name = "FacultyListBox";
            this.FacultyListBox.Size = new System.Drawing.Size(536, 544);
            this.FacultyListBox.TabIndex = 7;
            this.FacultyListBox.SelectedIndexChanged += new System.EventHandler(this.OnFacultySelect);
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(706, 815);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(285, 25);
            this.AddFacultyLink.TabIndex = 8;
            this.AddFacultyLink.TabStop = true;
            this.AddFacultyLink.Text = "Cant find your Faculty? Add it here";
            this.AddFacultyLink.Click += new System.EventHandler(this.OnAddFacultyClick);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(704, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Faculties";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.FacultiesVal);
            this.groupBox1.Controls.Add(this.OveralVal);
            this.groupBox1.Controls.Add(this.ReviewsVal);
            this.groupBox1.Controls.Add(this.SalaryVal);
            this.groupBox1.Controls.Add(this.UniOveral);
            this.groupBox1.Controls.Add(this.UniReviews);
            this.groupBox1.Controls.Add(this.UniFaculties);
            this.groupBox1.Controls.Add(this.UniSalary);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(241, 559);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(368, 237);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // FacultiesVal
            // 
            this.FacultiesVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultiesVal.AutoSize = true;
            this.FacultiesVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FacultiesVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultiesVal.Location = new System.Drawing.Point(144, 94);
            this.FacultiesVal.Name = "FacultiesVal";
            this.FacultiesVal.Size = new System.Drawing.Size(23, 25);
            this.FacultiesVal.TabIndex = 20;
            this.FacultiesVal.Text = "X";
            // 
            // OveralVal
            // 
            this.OveralVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.OveralVal.AutoSize = true;
            this.OveralVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.OveralVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OveralVal.Location = new System.Drawing.Point(135, 177);
            this.OveralVal.Name = "OveralVal";
            this.OveralVal.Size = new System.Drawing.Size(23, 25);
            this.OveralVal.TabIndex = 19;
            this.OveralVal.Text = "X";
            // 
            // ReviewsVal
            // 
            this.ReviewsVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ReviewsVal.AutoSize = true;
            this.ReviewsVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ReviewsVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewsVal.Location = new System.Drawing.Point(134, 135);
            this.ReviewsVal.Name = "ReviewsVal";
            this.ReviewsVal.Size = new System.Drawing.Size(23, 25);
            this.ReviewsVal.TabIndex = 18;
            this.ReviewsVal.Text = "X";
            // 
            // SalaryVal
            // 
            this.SalaryVal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalaryVal.AutoSize = true;
            this.SalaryVal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SalaryVal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalaryVal.Location = new System.Drawing.Point(202, 51);
            this.SalaryVal.Name = "SalaryVal";
            this.SalaryVal.Size = new System.Drawing.Size(23, 25);
            this.SalaryVal.TabIndex = 16;
            this.SalaryVal.Text = "X";
            // 
            // UniOveral
            // 
            this.UniOveral.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniOveral.AutoSize = true;
            this.UniOveral.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UniOveral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniOveral.Location = new System.Drawing.Point(15, 177);
            this.UniOveral.Name = "UniOveral";
            this.UniOveral.Size = new System.Drawing.Size(118, 25);
            this.UniOveral.TabIndex = 15;
            this.UniOveral.Text = "Overal rating:";
            // 
            // UniReviews
            // 
            this.UniReviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniReviews.AutoSize = true;
            this.UniReviews.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UniReviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniReviews.Location = new System.Drawing.Point(15, 135);
            this.UniReviews.Name = "UniReviews";
            this.UniReviews.Size = new System.Drawing.Size(112, 25);
            this.UniReviews.TabIndex = 14;
            this.UniReviews.Text = "# of reviews:";
            // 
            // UniFaculties
            // 
            this.UniFaculties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniFaculties.AutoSize = true;
            this.UniFaculties.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UniFaculties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniFaculties.Location = new System.Drawing.Point(15, 94);
            this.UniFaculties.Name = "UniFaculties";
            this.UniFaculties.Size = new System.Drawing.Size(118, 25);
            this.UniFaculties.TabIndex = 13;
            this.UniFaculties.Text = "# of faculties:";
            // 
            // UniSalary
            // 
            this.UniSalary.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniSalary.AutoSize = true;
            this.UniSalary.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UniSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniSalary.Location = new System.Drawing.Point(15, 51);
            this.UniSalary.Name = "UniSalary";
            this.UniSalary.Size = new System.Drawing.Size(178, 25);
            this.UniSalary.TabIndex = 12;
            this.UniSalary.Text = "Avg. graduate salary:";
            // 
            // btnCompare
            // 
            this.btnCompare.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCompare.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompare.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCompare.Location = new System.Drawing.Point(241, 815);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(368, 54);
            this.btnCompare.TabIndex = 13;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.OnComparisonButtonClick);
            // 
            // UniversityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddFacultyLink);
            this.Controls.Add(this.FacultyListBox);
            this.Controls.Add(this.PreviousIndividualUniversityView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.UniversityTitleLabel);
            this.Name = "UniversityView";
            this.Text = "University";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.LoadUniversityData);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label OveralVal;
        private System.Windows.Forms.Label ReviewsVal;
        private System.Windows.Forms.Label SalaryVal;
        private System.Windows.Forms.Label UniOveral;
        private System.Windows.Forms.Label UniReviews;
        private System.Windows.Forms.Label UniFaculties;
        private System.Windows.Forms.Label UniSalary;
        private System.Windows.Forms.Label FacultiesVal;
        private System.Windows.Forms.Button btnCompare;
    }
}