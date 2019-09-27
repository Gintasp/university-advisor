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
            this.UniversityList = new System.Windows.Forms.ListBox();
            this.AddUniversity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(814, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "What university are you interested in at the moment?";
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.SystemColors.Window;
            this.searchBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchBox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.searchBox.HideSelection = false;
            this.searchBox.Location = new System.Drawing.Point(250, 107);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(400, 30);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.Enter += new System.EventHandler(this.PrimaryTextDeletion);
            this.searchBox.Leave += new System.EventHandler(this.SetPrimaryText);
            // 
            // UniversityList
            // 
            this.UniversityList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.UniversityList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityList.FormattingEnabled = true;
            this.UniversityList.ItemHeight = 23;
            this.UniversityList.Location = new System.Drawing.Point(250, 159);
            this.UniversityList.Name = "UniversityList";
            this.UniversityList.Size = new System.Drawing.Size(400, 188);
            this.UniversityList.TabIndex = 2;
            this.UniversityList.SelectedIndexChanged += new System.EventHandler(this.SelectedUniversity);
            // 
            // AddUniversity
            // 
            this.AddUniversity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.AddUniversity.Location = new System.Drawing.Point(358, 407);
            this.AddUniversity.Name = "AddUniversity";
            this.AddUniversity.Size = new System.Drawing.Size(158, 61);
            this.AddUniversity.TabIndex = 3;
            this.AddUniversity.Text = "Add University";
            this.AddUniversity.UseVisualStyleBackColor = true;
            this.AddUniversity.Click += new System.EventHandler(this.AddUniversityClicked);
            // 
            // WhatUniversityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 503);
            this.Controls.Add(this.AddUniversity);
            this.Controls.Add(this.UniversityList);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "WhatUniversityView";
            this.Text = "WhatUniversity";
            this.Load += new System.EventHandler(this.WhatUniversity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchBox;
        private System.Windows.Forms.ListBox UniversityList;
        private System.Windows.Forms.Button AddUniversity;


    }
}