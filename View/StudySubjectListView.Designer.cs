namespace Advisor.View
{
    partial class StudySubjectListView
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.StudySubjectList = new System.Windows.Forms.ListBox();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.btnAddStudySubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(223, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Study Subjects";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(162, 94);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(329, 25);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.OnSearchInputEnter);
            this.txtSearch.Leave += new System.EventHandler(this.OnSearchInputLeave);
            // 
            // StudySubjectList
            // 
            this.StudySubjectList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudySubjectList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudySubjectList.FormattingEnabled = true;
            this.StudySubjectList.ItemHeight = 17;
            this.StudySubjectList.Location = new System.Drawing.Point(162, 126);
            this.StudySubjectList.Margin = new System.Windows.Forms.Padding(2);
            this.StudySubjectList.Name = "StudySubjectList";
            this.StudySubjectList.Size = new System.Drawing.Size(329, 191);
            this.StudySubjectList.TabIndex = 2;
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(9, 8);
            this.PreviousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(19, 13);
            this.PreviousForm.TabIndex = 3;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // btnAddStudySubject
            // 
            this.btnAddStudySubject.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudySubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudySubject.Location = new System.Drawing.Point(219, 347);
            this.btnAddStudySubject.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudySubject.Name = "btnAddStudySubject";
            this.btnAddStudySubject.Size = new System.Drawing.Size(213, 38);
            this.btnAddStudySubject.TabIndex = 4;
            this.btnAddStudySubject.Text = "Add Study Subject";
            this.btnAddStudySubject.UseVisualStyleBackColor = true;
            this.btnAddStudySubject.Click += new System.EventHandler(this.OnAddStudySubjectButtonClick);
            // 
            // StudySubjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 409);
            this.Controls.Add(this.btnAddStudySubject);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.StudySubjectList);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudySubjectListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Subjects";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
            this.Load += new System.EventHandler(this.LoadStudySubjectData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox StudySubjectList;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.Button btnAddStudySubject;
    }
}