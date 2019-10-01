namespace Advisor.View
{
    partial class LecturerListView
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
            this.previousForm = new System.Windows.Forms.LinkLabel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.LecturerData = new System.Windows.Forms.ListBox();
            this.btnAddLecturer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(413, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lecturers";
            // 
            // previousForm
            // 
            this.previousForm.AutoSize = true;
            this.previousForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousForm.Location = new System.Drawing.Point(11, 9);
            this.previousForm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.previousForm.Name = "previousForm";
            this.previousForm.Size = new System.Drawing.Size(24, 17);
            this.previousForm.TabIndex = 4;
            this.previousForm.TabStop = true;
            this.previousForm.Text = "<<";
            this.previousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormButtonClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.Location = new System.Drawing.Point(294, 163);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(415, 29);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.OnSearchInputEnter);
            this.txtSearch.Leave += new System.EventHandler(this.OnSearchInputLeave);
            // 
            // LecturerData
            // 
            this.LecturerData.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LecturerData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LecturerData.FormattingEnabled = true;
            this.LecturerData.ItemHeight = 21;
            this.LecturerData.Location = new System.Drawing.Point(294, 198);
            this.LecturerData.Name = "LecturerData";
            this.LecturerData.Size = new System.Drawing.Size(415, 235);
            this.LecturerData.TabIndex = 6;
            this.LecturerData.SelectedIndexChanged += new System.EventHandler(this.SelectedLecturer);
            // 
            // btnAddLecturer
            // 
            this.btnAddLecturer.AutoSize = true;
            this.btnAddLecturer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLecturer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddLecturer.Location = new System.Drawing.Point(294, 446);
            this.btnAddLecturer.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.btnAddLecturer.Name = "btnAddLecturer";
            this.btnAddLecturer.Size = new System.Drawing.Size(415, 31);
            this.btnAddLecturer.TabIndex = 7;
            this.btnAddLecturer.Text = "Add a lecturer";
            this.btnAddLecturer.UseVisualStyleBackColor = true;
            this.btnAddLecturer.Click += new System.EventHandler(this.OnAddLecturerButtonClick);
            // 
            // LecturerListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 613);
            this.Controls.Add(this.btnAddLecturer);
            this.Controls.Add(this.LecturerData);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.previousForm);
            this.Controls.Add(this.label1);
            this.Name = "LecturerListView";
            this.Text = "Lecturers";
            this.Load += new System.EventHandler(this.LoadLecturerData);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel previousForm;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ListBox LecturerData;
        private System.Windows.Forms.Button btnAddLecturer;
    }
}