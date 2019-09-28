namespace Advisor.View
{
    partial class UniversityView
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.UniversityTitleLabel = new System.Windows.Forms.Label();
            this.About = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Faculties = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PreviousIndividualUniversityView = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UniversityTitleLabel
            // 
            this.UniversityTitleLabel.AutoSize = true;
            this.UniversityTitleLabel.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.UniversityTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UniversityTitleLabel.Location = new System.Drawing.Point(37, 187);
            this.UniversityTitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UniversityTitleLabel.MaximumSize = new System.Drawing.Size(165, 0);
            this.UniversityTitleLabel.Name = "UniversityTitleLabel";
            this.UniversityTitleLabel.Size = new System.Drawing.Size(68, 37);
            this.UniversityTitleLabel.TabIndex = 0;
            this.UniversityTitleLabel.Text = "Title";
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.About.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.About.Location = new System.Drawing.Point(336, 49);
            this.About.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(90, 37);
            this.About.TabIndex = 1;
            this.About.Text = "About";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(342, 89);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 266);
            this.panel1.TabIndex = 2;
            // 
            // Faculties
            // 
            this.Faculties.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Faculties.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Faculties.Location = new System.Drawing.Point(44, 319);
            this.Faculties.Margin = new System.Windows.Forms.Padding(2);
            this.Faculties.Name = "Faculties";
            this.Faculties.Size = new System.Drawing.Size(219, 36);
            this.Faculties.TabIndex = 3;
            this.Faculties.Text = "Faculties";
            this.Faculties.UseVisualStyleBackColor = true;
            this.Faculties.Click += new System.EventHandler(this.OnFacultiesButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(44, 49);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 117);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // PreviousIndividualUniversityView
            // 
            this.PreviousIndividualUniversityView.AutoSize = true;
            this.PreviousIndividualUniversityView.Location = new System.Drawing.Point(9, 7);
            this.PreviousIndividualUniversityView.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PreviousIndividualUniversityView.Name = "PreviousIndividualUniversityView";
            this.PreviousIndividualUniversityView.Size = new System.Drawing.Size(19, 13);
            this.PreviousIndividualUniversityView.TabIndex = 6;
            this.PreviousIndividualUniversityView.TabStop = true;
            this.PreviousIndividualUniversityView.Text = "<<";
            this.PreviousIndividualUniversityView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousButtonClick);
            // 
            // UniversityView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 391);
            this.Controls.Add(this.PreviousIndividualUniversityView);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Faculties);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.About);
            this.Controls.Add(this.UniversityTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UniversityView";
            this.Text = "University";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.onFormClose);
            this.Load += new System.EventHandler(this.LoadUniversityTitle);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label UniversityTitleLabel;
        private System.Windows.Forms.Label About;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Faculties;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel PreviousIndividualUniversityView;
    }
}