namespace Advisor.View
{
    partial class AddFormView
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
            this.Title = new System.Windows.Forms.Label();
            this.InputLabel = new System.Windows.Forms.Label();
            this.DescLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.LectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Title.Location = new System.Drawing.Point(152, 63);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(505, 51);
            this.Title.TabIndex = 0;
            this.Title.Text = "Add New";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.InputLabel.Location = new System.Drawing.Point(222, 176);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(37, 19);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "Title:";
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DescLabel.Location = new System.Drawing.Point(222, 247);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(81, 19);
            this.DescLabel.TabIndex = 2;
            this.DescLabel.Text = "Description:";
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TextBox.Location = new System.Drawing.Point(226, 199);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(352, 31);
            this.TextBox.TabIndex = 3;
            // 
            // RichTextBox
            // 
            this.RichTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RichTextBox.Location = new System.Drawing.Point(226, 269);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(352, 134);
            this.RichTextBox.TabIndex = 4;
            this.RichTextBox.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(226, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnAddButtonClick);
            // 
            // ComboBox
            // 
            this.ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(226, 269);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(352, 25);
            this.ComboBox.TabIndex = 6;
            this.ComboBox.Visible = false;
            // 
            // LectLabel
            // 
            this.LectLabel.AutoSize = true;
            this.LectLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.LectLabel.Location = new System.Drawing.Point(224, 248);
            this.LectLabel.Name = "LectLabel";
            this.LectLabel.Size = new System.Drawing.Size(62, 19);
            this.LectLabel.TabIndex = 7;
            this.LectLabel.Text = "Lecturer:";
            this.LectLabel.Visible = false;
            // 
            // AddFormView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 503);
            this.Controls.Add(this.LectLabel);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.Title);
            this.Name = "AddFormView";
            this.Text = "Add new";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Label DescLabel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.RichTextBox RichTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label LectLabel;
    }
}