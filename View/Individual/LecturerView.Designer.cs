namespace Advisor.View
{
    partial class LecturerView
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
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.btnLeaveReview = new System.Windows.Forms.Button();
            this.CourseData = new System.Windows.Forms.ListBox();
            this.ReviewData = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkAddCourse = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousForm.Location = new System.Drawing.Point(11, 9);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(24, 17);
            this.PreviousForm.TabIndex = 7;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormLinkClick);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelName.Location = new System.Drawing.Point(63, 164);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(122, 51);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelFaculty.Location = new System.Drawing.Point(68, 215);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(58, 21);
            this.labelFaculty.TabIndex = 10;
            this.labelFaculty.Text = "Faculty";
            // 
            // btnLeaveReview
            // 
            this.btnLeaveReview.AutoSize = true;
            this.btnLeaveReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeaveReview.Location = new System.Drawing.Point(705, 550);
            this.btnLeaveReview.Name = "btnLeaveReview";
            this.btnLeaveReview.Size = new System.Drawing.Size(287, 31);
            this.btnLeaveReview.TabIndex = 11;
            this.btnLeaveReview.Text = "Leave a review";
            this.btnLeaveReview.UseVisualStyleBackColor = true;
            this.btnLeaveReview.Click += new System.EventHandler(this.OnLeaveReviewButtonClick);
            // 
            // CourseData
            // 
            this.CourseData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CourseData.FormattingEnabled = true;
            this.CourseData.ItemHeight = 21;
            this.CourseData.Location = new System.Drawing.Point(362, 204);
            this.CourseData.Name = "CourseData";
            this.CourseData.Size = new System.Drawing.Size(325, 340);
            this.CourseData.TabIndex = 12;
            this.CourseData.SelectedIndexChanged += new System.EventHandler(this.OnCourseSelect);
            // 
            // ReviewData
            // 
            this.ReviewData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReviewData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewData.FormattingEnabled = true;
            this.ReviewData.ItemHeight = 21;
            this.ReviewData.Location = new System.Drawing.Point(705, 204);
            this.ReviewData.Name = "ReviewData";
            this.ReviewData.Size = new System.Drawing.Size(325, 340);
            this.ReviewData.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(355, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Courses";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(698, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Reviews";
            // 
            // linkAddCourse
            // 
            this.linkAddCourse.AutoSize = true;
            this.linkAddCourse.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAddCourse.Location = new System.Drawing.Point(359, 547);
            this.linkAddCourse.Name = "linkAddCourse";
            this.linkAddCourse.Size = new System.Drawing.Size(193, 15);
            this.linkAddCourse.TabIndex = 16;
            this.linkAddCourse.TabStop = true;
            this.linkAddCourse.Text = "Can\'t find your course? Add it here!";
            this.linkAddCourse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnAddCourseLinkClick);
            // 
            // LecturerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 631);
            this.Controls.Add(this.linkAddCourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ReviewData);
            this.Controls.Add(this.CourseData);
            this.Controls.Add(this.btnLeaveReview);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.PreviousForm);
            this.Name = "LecturerView";
            this.Text = "Lecturer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.Button btnLeaveReview;
        private System.Windows.Forms.ListBox CourseData;
        private System.Windows.Forms.ListBox ReviewData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkAddCourse;
    }
}