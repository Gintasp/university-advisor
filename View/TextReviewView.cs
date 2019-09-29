using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Advisor.Controller;

namespace Advisor.View
{
    public partial class TextReviewView : Form
    {
        public ITextReviewController TextReviewController { get; set; }
        public TextReviewView(ITextReviewController textReviewController)
        {
            TextReviewController = textReviewController;
            textReviewController.TextReviewView = this;
            InitializeComponent();
        }

        private void OnSubmitReviewButtonClick(object sender, EventArgs e)
        {
            TextReviewController.HandleSubmitReviewButtonClick();
        }

        private void OnPreviousFormLinkClick(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TextReviewController.HandlePreviousFormLinkClick();
        }
    }
}
