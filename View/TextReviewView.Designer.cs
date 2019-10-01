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
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.PreviousForm = new System.Windows.Forms.LinkLabel();
            this.ReviewScoreBar = new System.Windows.Forms.TrackBar();
            this.ScoreLabel = new System.Windows.Forms.Label();
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
            this.ReviewTextBox.Location = new System.Drawing.Point(295, 186);
            this.ReviewTextBox.Name = "ReviewTextBox";
            this.ReviewTextBox.Size = new System.Drawing.Size(414, 212);
            this.ReviewTextBox.TabIndex = 1;
            this.ReviewTextBox.Text = "";
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmitReview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSubmitReview.Location = new System.Drawing.Point(295, 455);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(414, 37);
            this.btnSubmitReview.TabIndex = 2;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.UseVisualStyleBackColor = true;
            this.btnSubmitReview.Click += new System.EventHandler(this.OnSubmitReviewButtonClick);
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
            this.ReviewScoreBar.Location = new System.Drawing.Point(374, 404);
            this.ReviewScoreBar.Minimum = 1;
            this.ReviewScoreBar.Name = "ReviewScoreBar";
            this.ReviewScoreBar.Size = new System.Drawing.Size(335, 45);
            this.ReviewScoreBar.TabIndex = 11;
            this.ReviewScoreBar.Value = 1;
            // 
            // ScoreLabel
            // 
            this.ScoreLabel.AutoSize = true;
            this.ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreLabel.Location = new System.Drawing.Point(294, 404);
            this.ScoreLabel.Name = "ScoreLabel";
            this.ScoreLabel.Size = new System.Drawing.Size(74, 17);
            this.ScoreLabel.TabIndex = 12;
            this.ScoreLabel.Text = "Your Score:";
            // 
            // TextReviewView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 614);
            this.Controls.Add(this.ScoreLabel);
            this.Controls.Add(this.ReviewScoreBar);
            this.Controls.Add(this.PreviousForm);
            this.Controls.Add(this.btnSubmitReview);
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
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.LinkLabel PreviousForm;
        private System.Windows.Forms.TrackBar ReviewScoreBar;
        private System.Windows.Forms.Label ScoreLabel;
    }
}