namespace Advisor.View
{
    partial class HomeView
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.UniversityData = new System.Windows.Forms.ListBox();
            this.AddFacultyLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(74, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(845, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "What university are you interested in at the moment?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBox.HideSelection = false;
            this.searchBox.Location = new System.Drawing.Point(248, 194);
            this.searchBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(415, 29);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.Enter += new System.EventHandler(this.PrimaryTextDeletion);
            this.searchBox.Leave += new System.EventHandler(this.SetPrimaryText);
            // 
            // UniversityData
            // 
            this.UniversityData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniversityData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversityData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityData.FormattingEnabled = true;
            this.UniversityData.ItemHeight = 21;
            this.UniversityData.Location = new System.Drawing.Point(248, 243);
            this.UniversityData.Margin = new System.Windows.Forms.Padding(2);
            this.UniversityData.Name = "UniversityData";
            this.UniversityData.Size = new System.Drawing.Size(415, 256);
            this.UniversityData.TabIndex = 2;
            this.UniversityData.SelectedIndexChanged += new System.EventHandler(this.SelectedUniversity);
            // 
            // AddFacultyLink
            // 
            this.AddFacultyLink.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddFacultyLink.AutoSize = true;
            this.AddFacultyLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFacultyLink.Location = new System.Drawing.Point(245, 507);
            this.AddFacultyLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddFacultyLink.Name = "AddFacultyLink";
            this.AddFacultyLink.Size = new System.Drawing.Size(203, 15);
            this.AddFacultyLink.TabIndex = 9;
            this.AddFacultyLink.TabStop = true;
            this.AddFacultyLink.Text = "Cant find your university? Add it here";
            this.AddFacultyLink.Click += new System.EventHandler(this.OnAddUniversityLinkClick);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 658);
            this.Controls.Add(this.AddFacultyLink);
            this.Controls.Add(this.UniversityData);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeView";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClose);
            this.Load += new System.EventHandler(this.LoadUniversityList);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox UniversityData;
        private System.Windows.Forms.LinkLabel AddFacultyLink;
    }
}