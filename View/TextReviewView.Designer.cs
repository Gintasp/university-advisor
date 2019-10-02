namespace Advisor.View
{
    partial class TextReviewView
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
            this.ReviewInputTitle = new System.Windows.Forms.Label();
            this.ReviewTextBox = new System.Windows.Forms.RichTextBox();
            this.SubmitReviewButton = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.ReviewScoreBar = new System.Windows.Forms.TrackBar();
            this.ScoreLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreBar)).BeginInit();
            this.SuspendLayout();
            // 
            // ReviewInputTitle
            // 
            this.ReviewInputTitle.AutoSize = true;
            this.ReviewInputTitle.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.ReviewInputTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReviewInputTitle.Location = new System.Drawing.Point(365, 92);
            this.ReviewInputTitle.Name = "ReviewInputTitle";
            this.ReviewInputTitle.Size = new System.Drawing.Size(272, 51);
            this.ReviewInputTitle.TabIndex = 0;
            this.ReviewInputTitle.Text = "Leave a Review";
            // 
            // ReviewTextBox
            // 
            this.ReviewTextBox.Location = new System.Drawing.Point(295, 189);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(414, 212);
            this.ReviewTextBox.TabIndex = 1;
            this.ReviewTextBox.Text = "";
            // 
            // SubmitReviewButton
            // 
            this.SubmitReviewButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitReviewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubmitReviewButton.Location = new System.Drawing.Point(295, 482);
            this.SubmitReviewButton.Name = "SubmitReviewButton";
            this.SubmitReviewButton.Size = new System.Drawing.Size(414, 37);
            this.SubmitReviewButton.TabIndex = 2;
            this.SubmitReviewButton.Text = "Submit Review";
            this.SubmitReviewButton.UseVisualStyleBackColor = true;
            this.SubmitReviewButton.Click += new System.EventHandler(this.OnSubmitReviewButtonClick);
            // 
            // PreviousForm
            // 
            this.PreviousForm.AutoSize = true;
            this.PreviousForm.Location = new System.Drawing.Point(12, 9);
            this.PreviousForm.Name = "PreviousForm";
            this.PreviousForm.Size = new System.Drawing.Size(19, 13);
            this.PreviousForm.TabIndex = 4;
            this.PreviousForm.TabStop = true;
            this.PreviousForm.Text = "<<";
            this.PreviousForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnPreviousFormLinkClick);
            // 
            // ReviewScoreBar
            // 
            this.ReviewScoreBar.Location = new System.Drawing.Point(297, 431);
            this.ReviewScoreBar.Minimum = 1;
            this.ReviewScoreBar.Name = "ReviewScoreBar";
            this.ReviewScoreBar.Size = new System.Drawing.Size(412, 45);
            this.ReviewScoreBar.TabIndex = 11;
            this.ReviewScoreBar.Value = 1;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ScoreLabel.Location = new System.Drawing.Point(294, 404);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(58, 21);
            this.ScoreLabel.TabIndex = 12;
            this.ScoreLabel.Text = "Rating:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label1.Location = new System.Drawing.Point(293, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Your review:";
            // 
            // TextReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ReviewScoreBar);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.SubmitReviewButton);
            this.Controls.Add(this.ReviewTextBox);
            this.Controls.Add(this.ReviewInputTitle);
            this.Name = "TextReviewView";
            this.Text = "ReviewView";
            ((System.ComponentModel.ISupportInitialize)(this.ReviewScoreBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReviewInputTitle;
        private System.Windows.Forms.RichTextBox ReviewTextBox;
        private System.Windows.Forms.Button SubmitReviewButton;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.TrackBar ReviewScoreBar;
        private System.Windows.Forms.Label ScoreLabel;
        private System.Windows.Forms.Label label1;
    }
}