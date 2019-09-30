namespace Advisor.View
{
    partial class FacultyListView
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
            this.FacultiesListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.PreviousFacultiesListView = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FacultiesListBox
            // 
            this.FacultiesListBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultiesListBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.FacultiesListBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultiesListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultiesListBox.FormattingEnabled = true;
            this.FacultiesListBox.ItemHeight = 32;
            this.FacultiesListBox.Location = new System.Drawing.Point(425, 209);
            this.FacultiesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.FacultiesListBox.Name = "FacultiesListBox";
            this.FacultiesListBox.Size = new System.Drawing.Size(621, 324);
            this.FacultiesListBox.TabIndex = 0;
            this.FacultiesListBox.SelectedIndexChanged += new System.EventHandler(this.OnFacultySelect);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(631, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 81);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faculties";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.HideSelection = false;
            this.txtSearch.Location = new System.Drawing.Point(425, 147);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(621, 39);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.OnSearchInputEnter);
            this.txtSearch.Leave += new System.EventHandler(this.OnSearchInputLeave);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddFaculty.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddFaculty.Location = new System.Drawing.Point(425, 601);
            this.btnAddFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(628, 59);
            this.btnAddFaculty.TabIndex = 3;
            this.btnAddFaculty.Text = "Add Faculty";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            this.btnAddFaculty.Click += new System.EventHandler(this.OnAddFacultyButtonClick);
            // 
            // PreviousFacultiesListView
            // 
            this.PreviousFacultiesListView.AutoSize = true;
            this.PreviousFacultiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousFacultiesListView.Location = new System.Drawing.Point(13, 13);
            this.PreviousFacultiesListView.Name = "PreviousFacultiesListView";
            this.PreviousFacultiesListView.Size = new System.Drawing.Size(36, 25);
            this.PreviousFacultiesListView.TabIndex = 4;
            this.PreviousFacultiesListView.TabStop = true;
            this.PreviousFacultiesListView.Text = "<<";
            this.PreviousFacultiesListView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // FacultyListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.PreviousFacultiesListView);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultiesListBox);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacultyListView";
            this.Text = "Faculties";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FacultiesListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.LinkLabel PreviousFacultiesListView;
    }
}