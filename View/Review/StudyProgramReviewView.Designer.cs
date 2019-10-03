namespace Advisor.View
{
    partial class StudyProgramReviewView
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
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.ReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.ReviewInputTitle = new System.Windows.Forms.Label();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.Incomelabel = new System.Windows.Forms.Label();
            this.txtIncome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.RadioSecond = new System.Windows.Forms.RadioButton();
            this.RadioFourth = new System.Windows.Forms.RadioButton();
            this.RadioFirst = new System.Windows.Forms.RadioButton();
            this.RadioThird = new System.Windows.Forms.RadioButton();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitReview.Location = new System.Drawing.Point(215, 523);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(414, 37);
            this.btnSubmitReview.TabIndex = 7;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.OnSubmitReviewButtonClick);
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReviewTextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ReviewTextBox.Location = new System.Drawing.Point(217, 423);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(414, 82);
            this.ReviewTextBox.TabIndex = 6;
            this.ReviewTextBox.Text = "";
            // 
            // ReviewInputTitle
            // 
            this.ReviewInputTitle.AutoSize = true;
            this.ReviewInputTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.ReviewInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewInputTitle.Location = new System.Drawing.Point(294, 57);
            this.ReviewInputTitle.Name = "ReviewInputTitle";
            this.ReviewInputTitle.Size = new System.Drawing.Size(272, 51);
            this.ReviewInputTitle.TabIndex = 5;
            this.ReviewInputTitle.Text = "Leave a Review";
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(4, 209);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(87, 17);
            this.ScoreLabel.TabIndex = 19;
            this.ScoreLabel.Text = "Overal rating:";
            // 
            // Incomelabel
            // 
            this.Incomelabel.AutoSize = true;
            this.Incomelabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Incomelabel.Location = new System.Drawing.Point(3, 19);
            this.Incomelabel.Name = "Incomelabel";
            this.Incomelabel.Size = new System.Drawing.Size(153, 19);
            this.Incomelabel.TabIndex = 21;
            this.Incomelabel.Text = "Current monthly salary:";
            // 
            // txtIncome
            // 
            this.txtIncome.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtIncome.Location = new System.Drawing.Point(210, 16);
            this.txtIncome.Name = "txtIncome";
            this.txtIncome.Size = new System.Drawing.Size(140, 25);
            this.txtIncome.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericUpDown3);
            this.panel1.Controls.Add(this.ScoreLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.Incomelabel);
            this.panel1.Controls.Add(this.txtIncome);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.panel1.Location = new System.Drawing.Point(217, 154);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 274);
            this.panel1.TabIndex = 22;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(210, 51);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(45, 25);
            this.numericUpDown1.TabIndex = 22;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.Location = new System.Drawing.Point(3, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "How difficult was this program:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(4, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Satisfaction with this program:";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(210, 82);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(45, 25);
            this.numericUpDown2.TabIndex = 25;
            this.numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.Location = new System.Drawing.Point(4, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 19);
            this.label3.TabIndex = 26;
            this.label3.Text = "Are you working in a relevant industry at the moment?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(17, 137);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 21);
            this.radioButton1.TabIndex = 27;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 137);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(44, 21);
            this.radioButton2.TabIndex = 28;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Which year into the program did you start your career?";
            // 
            // RadioSecond
            // 
            this.RadioSecond.AutoSize = true;
            this.RadioSecond.Location = new System.Drawing.Point(69, 13);
            this.RadioSecond.Name = "RadioSecond";
            this.RadioSecond.Size = new System.Drawing.Size(69, 21);
            this.RadioSecond.TabIndex = 30;
            this.RadioSecond.TabStop = true;
            this.RadioSecond.Text = "Second";
            this.RadioSecond.UseVisualStyleBackColor = true;
            // 
            // RadioFourth
            // 
            this.RadioFourth.AutoSize = true;
            this.RadioFourth.Location = new System.Drawing.Point(205, 13);
            this.RadioFourth.Name = "RadioFourth";
            this.RadioFourth.Size = new System.Drawing.Size(63, 21);
            this.RadioFourth.TabIndex = 31;
            this.RadioFourth.TabStop = true;
            this.RadioFourth.Text = "Fourth";
            this.RadioFourth.UseVisualStyleBackColor = true;
            // 
            // RadioFirst
            // 
            this.RadioFirst.AutoSize = true;
            this.RadioFirst.Location = new System.Drawing.Point(13, 13);
            this.RadioFirst.Name = "RadioFirst";
            this.RadioFirst.Size = new System.Drawing.Size(50, 21);
            this.RadioFirst.TabIndex = 32;
            this.RadioFirst.TabStop = true;
            this.RadioFirst.Text = "First";
            this.RadioFirst.UseVisualStyleBackColor = true;
            // 
            // RadioThird
            // 
            this.RadioThird.AutoSize = true;
            this.RadioThird.Location = new System.Drawing.Point(143, 13);
            this.RadioThird.Name = "RadioThird";
            this.RadioThird.Size = new System.Drawing.Size(56, 21);
            this.RadioThird.TabIndex = 33;
            this.RadioThird.TabStop = true;
            this.RadioThird.Text = "Third";
            this.RadioThird.UseVisualStyleBackColor = true;
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.Location = new System.Drawing.Point(97, 207);
            this.numericUpDown3.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(45, 25);
            this.numericUpDown3.TabIndex = 34;
            this.numericUpDown3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.Location = new System.Drawing.Point(4, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Any additional comments?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.Location = new System.Drawing.Point(136, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(571, 19);
            this.label6.TabIndex = 23;
            this.label6.Text = "Your anonymous reviews help us better assess study program quality across the uni" +
    "versities";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.RadioFirst);
            this.panel2.Controls.Add(this.RadioSecond);
            this.panel2.Controls.Add(this.RadioThird);
            this.panel2.Controls.Add(this.RadioFourth);
            this.panel2.Location = new System.Drawing.Point(5, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 43);
            this.panel2.TabIndex = 35;
            // 
            // StudyProgramReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(837, 614);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmitReview);
            this.Controls.Add(this.ReviewInputTitle);
            this.Name = "StudyProgramReviewView";
            this.Text = "Leave a review";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.RichTextBox ReviewTextBox;
        private System.Windows.Forms.Label ReviewInputTitle;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label Incomelabel;
        private System.Windows.Forms.TextBox txtIncome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioThird;
        private System.Windows.Forms.RadioButton RadioFirst;
        private System.Windows.Forms.RadioButton RadioFourth;
        private System.Windows.Forms.RadioButton RadioSecond;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
    }
}