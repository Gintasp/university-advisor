namespace Advisor.View
{
    partial class CourseView
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
            this.leaveReviewButton = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.Reviews = new System.Windows.Forms.ListBox();
            this.CourseTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Overal = new System.Windows.Forms.Label();
            this.Satisfaction = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.Usefulness = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Theory = new System.Windows.Forms.Label();
            this.Practice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leaveReviewButton
            // 
            this.leaveReviewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leaveReviewButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.leaveReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.leaveReviewButton.Location = new System.Drawing.Point(34, 347);
            this.leaveReviewButton.Margin = new System.Windows.Forms.Padding(2);
            this.leaveReviewButton.Name = "leaveReviewButton";
            this.leaveReviewButton.Size = new System.Drawing.Size(650, 37);
            this.leaveReviewButton.TabIndex = 9;
            this.leaveReviewButton.Text = "Leave a review";
            this.leaveReviewButton.UseVisualStyleBackColor = true;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(9, 7);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(19, 13);
            this.PreviousForm.TabIndex = 8;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // Reviews
            // 
            this.Reviews.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Reviews.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Reviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Reviews.FormattingEnabled = true;
            this.Reviews.ItemHeight = 21;
            this.Reviews.Location = new System.Drawing.Point(270, 102);
            this.Reviews.Margin = new System.Windows.Forms.Padding(2);
            this.Reviews.Name = "Reviews";
            this.Reviews.Size = new System.Drawing.Size(415, 235);
            this.Reviews.TabIndex = 7;
            // 
            // CourseTitle
            // 
            this.CourseTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CourseTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.CourseTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseTitle.Location = new System.Drawing.Point(34, 0);
            this.CourseTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CourseTitle.Name = "CourseTitle";
            this.CourseTitle.Size = new System.Drawing.Size(650, 51);
            this.CourseTitle.TabIndex = 5;
            this.CourseTitle.Text = "Course";
            this.CourseTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Practice);
            this.groupBox1.Controls.Add(this.Theory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Overal);
            this.groupBox1.Controls.Add(this.Satisfaction);
            this.groupBox1.Controls.Add(this.Difficulty);
            this.groupBox1.Controls.Add(this.Usefulness);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(34, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 240);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stats";
            // 
            // Overal
            // 
            this.Overal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Overal.AutoSize = true;
            this.Overal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Overal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Overal.Location = new System.Drawing.Point(96, 120);
            this.Overal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Overal.Name = "Overal";
            this.Overal.Size = new System.Drawing.Size(14, 15);
            this.Overal.TabIndex = 19;
            this.Overal.Text = "X";
            // 
            // Satisfaction
            // 
            this.Satisfaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Satisfaction.AutoSize = true;
            this.Satisfaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Satisfaction.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Satisfaction.Location = new System.Drawing.Point(93, 93);
            this.Satisfaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Satisfaction.Name = "Satisfaction";
            this.Satisfaction.Size = new System.Drawing.Size(14, 15);
            this.Satisfaction.TabIndex = 18;
            this.Satisfaction.Text = "X";
            // 
            // Difficulty
            // 
            this.Difficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Difficulty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Difficulty.Location = new System.Drawing.Point(77, 64);
            this.Difficulty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(14, 15);
            this.Difficulty.TabIndex = 17;
            this.Difficulty.Text = "X";
            // 
            // Usefulness
            // 
            this.Usefulness.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usefulness.AutoSize = true;
            this.Usefulness.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Usefulness.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Usefulness.Location = new System.Drawing.Point(86, 37);
            this.Usefulness.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Usefulness.Name = "Usefulness";
            this.Usefulness.Size = new System.Drawing.Size(14, 15);
            this.Usefulness.TabIndex = 16;
            this.Usefulness.Text = "X";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(13, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Overal rating:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(14, 92);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Satisfaction:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(13, 64);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Difficulty:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(13, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Usefulness:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(13, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Theory:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(13, 174);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Practice:";
            // 
            // Theory
            // 
            this.Theory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Theory.AutoSize = true;
            this.Theory.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Theory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Theory.Location = new System.Drawing.Point(71, 147);
            this.Theory.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Theory.Name = "Theory";
            this.Theory.Size = new System.Drawing.Size(14, 15);
            this.Theory.TabIndex = 22;
            this.Theory.Text = "X";
            // 
            // Practice
            // 
            this.Practice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Practice.AutoSize = true;
            this.Practice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Practice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Practice.Location = new System.Drawing.Point(77, 174);
            this.Practice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Practice.Name = "Practice";
            this.Practice.Size = new System.Drawing.Size(14, 15);
            this.Practice.TabIndex = 23;
            this.Practice.Text = "X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(265, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Reviews";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.leaveReviewButton);
            this.panel1.Controls.Add(this.Reviews);
            this.panel1.Controls.Add(this.CourseTitle);
            this.panel1.Location = new System.Drawing.Point(152, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(708, 404);
            this.panel1.TabIndex = 14;
            // 
            // CourseView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 609);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PreviousForm);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CourseView";
            this.Text = "Course";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button leaveReviewButton;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.ListBox Reviews;
        private System.Windows.Forms.Label CourseTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Overal;
        private System.Windows.Forms.Label Satisfaction;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.Label Usefulness;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Practice;
        private System.Windows.Forms.Label Theory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
    }
}