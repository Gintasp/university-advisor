namespace Advisor.View.Comparison
{
    partial class SelectPopup
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
            this.Button = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Combo3 = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Combo1 = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Combo2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Button
            // 
            this.Button.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Button.Location = new System.Drawing.Point(170, 289);
            this.Button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(254, 37);
            this.Button.TabIndex = 29;
            this.Button.Text = "Select";
            this.Button.UseVisualStyleBackColor = true;
            this.Button.Click += new System.EventHandler(this.OnSelectClick);
            // 
            // Label3
            // 
            this.Label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label3.Location = new System.Drawing.Point(122, 210);
            this.Label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(0, 21);
            this.Label3.TabIndex = 28;
            // 
            // Combo3
            // 
            this.Combo3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Combo3.FormattingEnabled = true;
            this.Combo3.Location = new System.Drawing.Point(122, 239);
            this.Combo3.Margin = new System.Windows.Forms.Padding(2);
            this.Combo3.Name = "Combo3";
            this.Combo3.Size = new System.Drawing.Size(361, 29);
            this.Combo3.TabIndex = 27;
            // 
            // Label1
            // 
            this.Label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label1.Location = new System.Drawing.Point(118, 64);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(83, 21);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "University:";
            // 
            // Combo1
            // 
            this.Combo1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Combo1.FormattingEnabled = true;
            this.Combo1.Location = new System.Drawing.Point(122, 91);
            this.Combo1.Margin = new System.Windows.Forms.Padding(2);
            this.Combo1.Name = "Combo1";
            this.Combo1.Size = new System.Drawing.Size(361, 29);
            this.Combo1.TabIndex = 25;
            this.Combo1.SelectedIndexChanged += new System.EventHandler(this.OnComboFirstSelect);
            // 
            // Label2
            // 
            this.Label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Label2.Location = new System.Drawing.Point(118, 137);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(61, 21);
            this.Label2.TabIndex = 24;
            this.Label2.Text = "Faculty:";
            // 
            // Combo2
            // 
            this.Combo2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Combo2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Combo2.FormattingEnabled = true;
            this.Combo2.Location = new System.Drawing.Point(122, 164);
            this.Combo2.Margin = new System.Windows.Forms.Padding(2);
            this.Combo2.Name = "Combo2";
            this.Combo2.Size = new System.Drawing.Size(361, 29);
            this.Combo2.TabIndex = 23;
            this.Combo2.SelectedIndexChanged += new System.EventHandler(this.OnComboSecondSelect);
            // 
            // SelectPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Combo3);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Combo1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Combo2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopupLecturerComparisonView";
            this.Load += new System.EventHandler(this.OnViewLoad);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.ComboBox Combo3;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox Combo1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.ComboBox Combo2;
    }
}