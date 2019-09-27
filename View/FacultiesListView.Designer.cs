namespace Advisor.View
{
    partial class FacultiesListView
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
            this.FacultiesList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAddFaculty = new System.Windows.Forms.Button();
            this.PreviousFacultiesListView = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // FacultiesList
            // 
            this.FacultiesList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultiesList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultiesList.FormattingEnabled = true;
            this.FacultiesList.ItemHeight = 23;
            this.FacultiesList.Location = new System.Drawing.Point(246, 192);
            this.FacultiesList.Margin = new System.Windows.Forms.Padding(4);
            this.FacultiesList.Name = "FacultiesList";
            this.FacultiesList.Size = new System.Drawing.Size(492, 303);
            this.FacultiesList.TabIndex = 0;
            this.FacultiesList.SelectedIndexChanged += new System.EventHandler(this.SelectedFaculty);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(397, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Faculties";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtSearch.HideSelection = false;
            this.txtSearch.Location = new System.Drawing.Point(246, 141);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(492, 30);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Text = "Search";
            this.txtSearch.Enter += new System.EventHandler(this.TxtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.TxtSearch_Leave);
            // 
            // btnAddFaculty
            // 
            this.btnAddFaculty.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFaculty.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAddFaculty.Location = new System.Drawing.Point(332, 534);
            this.btnAddFaculty.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddFaculty.Name = "btnAddFaculty";
            this.btnAddFaculty.Size = new System.Drawing.Size(320, 59);
            this.btnAddFaculty.TabIndex = 3;
            this.btnAddFaculty.Text = "Add Faculty";
            this.btnAddFaculty.UseVisualStyleBackColor = true;
            this.btnAddFaculty.Click += new System.EventHandler(this.BtnAddFaculty_Click);
            // 
            // PreviousFacultiesListView
            // 
            this.PreviousFacultiesListView.AutoSize = true;
            this.PreviousFacultiesListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreviousFacultiesListView.Location = new System.Drawing.Point(13, 13);
            this.PreviousFacultiesListView.Name = "PreviousFacultiesListView";
            this.PreviousFacultiesListView.Size = new System.Drawing.Size(24, 17);
            this.PreviousFacultiesListView.TabIndex = 4;
            this.PreviousFacultiesListView.TabStop = true;
            this.PreviousFacultiesListView.Text = "<<";
            this.PreviousFacultiesListView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PreviousForm_LinkClicked);
            // 
            // FacultiesListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 629);
            this.Controls.Add(this.PreviousFacultiesListView);
            this.Controls.Add(this.btnAddFaculty);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FacultiesList);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FacultiesListView";
            this.Text = "FacultiesListView";
            this.Load += new System.EventHandler(this.FacultiesListView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FacultiesList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAddFaculty;
        private System.Windows.Forms.LinkLabel PreviousFacultiesListView;
    }
}