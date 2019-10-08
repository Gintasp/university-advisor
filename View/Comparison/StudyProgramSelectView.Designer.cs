namespace Advisor.View
{
    partial class StudyProgramSelectView
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChoose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.StudyProgramSelectBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UniversitySelectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.FacultySelectBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnChoose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.StudyProgramSelectBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UniversitySelectBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FacultySelectBox);
            this.panel1.Location = new System.Drawing.Point(84, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 319);
            this.panel1.TabIndex = 24;
            // 
            // btnChoose
            // 
            this.btnChoose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChoose.Location = new System.Drawing.Point(20, 260);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(2);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(361, 37);
            this.btnChoose.TabIndex = 22;
            this.btnChoose.Text = "Choose";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.OnChooseButtonClick);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(20, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 21);
            this.label2.TabIndex = 21;
            this.label2.Text = "Study program:";
            // 
            // StudyProgramSelectBox
            // 
            this.StudyProgramSelectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StudyProgramSelectBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudyProgramSelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StudyProgramSelectBox.FormattingEnabled = true;
            this.StudyProgramSelectBox.Location = new System.Drawing.Point(20, 210);
            this.StudyProgramSelectBox.Margin = new System.Windows.Forms.Padding(2);
            this.StudyProgramSelectBox.Name = "StudyProgramSelectBox";
            this.StudyProgramSelectBox.Size = new System.Drawing.Size(361, 29);
            this.StudyProgramSelectBox.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(16, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "University:";
            // 
            // UniversitySelectBox
            // 
            this.UniversitySelectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UniversitySelectBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniversitySelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversitySelectBox.FormattingEnabled = true;
            this.UniversitySelectBox.Location = new System.Drawing.Point(20, 48);
            this.UniversitySelectBox.Margin = new System.Windows.Forms.Padding(2);
            this.UniversitySelectBox.Name = "UniversitySelectBox";
            this.UniversitySelectBox.Size = new System.Drawing.Size(361, 29);
            this.UniversitySelectBox.TabIndex = 18;
            this.UniversitySelectBox.SelectedIndexChanged += new System.EventHandler(this.OnUniversitySelect);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(16, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 21);
            this.label3.TabIndex = 17;
            this.label3.Text = "Faculty:";
            // 
            // FacultySelectBox
            // 
            this.FacultySelectBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FacultySelectBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacultySelectBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FacultySelectBox.FormattingEnabled = true;
            this.FacultySelectBox.Location = new System.Drawing.Point(20, 130);
            this.FacultySelectBox.Margin = new System.Windows.Forms.Padding(2);
            this.FacultySelectBox.Name = "FacultySelectBox";
            this.FacultySelectBox.Size = new System.Drawing.Size(361, 29);
            this.FacultySelectBox.TabIndex = 16;
            this.FacultySelectBox.SelectedIndexChanged += new System.EventHandler(this.OnFacultySelect);
            // 
            // StudyProgramSelectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 388);
            this.Controls.Add(this.panel1);
            this.Name = "StudyProgramSelectView";
            this.Text = "StudyProgramSelectForm";
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox StudyProgramSelectBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox UniversitySelectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox FacultySelectBox;
    }
}