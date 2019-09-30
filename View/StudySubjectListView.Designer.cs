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
            this.StudySubjectData = new System.Windows.Forms.ListBox();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.btnAddStudySubject = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(484, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Study Subjects";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(382, 201);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(552, 34);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.OnSearchInputEnter);
            this.txtSearch.Leave += new System.EventHandler(this.OnSearchInputLeave);
            // 
            // StudySubjectData
            // 
            this.StudySubjectData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudySubjectData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudySubjectData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudySubjectData.FormattingEnabled = true;
            this.StudySubjectData.ItemHeight = 28;
            this.StudySubjectData.Location = new System.Drawing.Point(380, 251);
            this.StudySubjectData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StudySubjectData.Name = "StudySubjectData";
            this.StudySubjectData.Size = new System.Drawing.Size(552, 312);
            this.StudySubjectData.TabIndex = 2;
            this.StudySubjectData.SelectedIndexChanged += new System.EventHandler(this.SelectedSubject);
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousForm.Location = new System.Drawing.Point(12, 10);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(29, 20);
            this.PreviousForm.TabIndex = 3;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // btnAddStudySubject
            // 
            this.btnAddStudySubject.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddStudySubject.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudySubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddStudySubject.Location = new System.Drawing.Point(380, 614);
            this.btnAddStudySubject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddStudySubject.Name = "btnAddStudySubject";
            this.btnAddStudySubject.Size = new System.Drawing.Size(552, 46);
            this.btnAddStudySubject.TabIndex = 4;
            this.btnAddStudySubject.Text = "Add Study Subject";
            this.btnAddStudySubject.UseVisualStyleBackColor = true;
            this.btnAddStudySubject.Click += new System.EventHandler(this.OnAddStudySubjectButtonClick);
            // 
            // StudySubjectListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1314, 755);
            this.Controls.Add(this.btnAddStudySubject);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.StudySubjectData);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "StudySubjectListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Subjects";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
            this.Load += new System.EventHandler(this.LoadStudySubjectData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox StudySubjectData;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.Button btnAddStudySubject;
    }
}