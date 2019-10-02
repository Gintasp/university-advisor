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
            this.AddUniversity = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(117, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1245, 70);
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
            this.searchBox.Location = new System.Drawing.Point(372, 242);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(621, 39);
            this.searchBox.TabIndex = 1;
            this.searchBox.Text = "Search";
            this.searchBox.Enter += new System.EventHandler(this.PrimaryTextDeletion);
            this.searchBox.Leave += new System.EventHandler(this.SetPrimaryText);
            // 
            // UniversityList
            // 
            this.UniversityData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniversityData.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversityData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityData.FormattingEnabled = true;
            this.UniversityData.ItemHeight = 32;
            this.UniversityData.Location = new System.Drawing.Point(372, 320);
            this.UniversityData.Name = "UniversityList";
            this.UniversityData.Size = new System.Drawing.Size(621, 420);
            this.UniversityData.TabIndex = 2;
            this.UniversityData.SelectedIndexChanged += new System.EventHandler(this.SelectedUniversity);
            // 
            // AddUniversity
            // 
            this.AddUniversity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUniversity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUniversity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AddUniversity.Location = new System.Drawing.Point(372, 780);
            this.AddUniversity.Name = "AddUniversity";
            this.AddUniversity.Size = new System.Drawing.Size(621, 60);
            this.AddUniversity.TabIndex = 3;
            this.AddUniversity.Text = "Add University";
            this.AddUniversity.UseVisualStyleBackColor = true;
            this.AddUniversity.Click += new System.EventHandler(this.OnAddUniversityButtonClick);
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1478, 944);
            this.Controls.Add(this.AddUniversity);
            this.Controls.Add(this.UniversityData);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Button AddUniversity;
        private System.Windows.Forms.ListBox UniversityData;
    }
}