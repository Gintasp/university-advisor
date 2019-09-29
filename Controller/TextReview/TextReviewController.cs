using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View;

namespace Advisor.Controller
{
    class TextReviewController : ITextReviewController
    {
        public TextReviewView TextReviewView { get; set; }

        public void HandleSubmitReviewButtonClick()
        {
            //TODO: Implement review object creation and storing
        }

        public void HandlePreviousFormLinkClick()
        {
            //TODO: Implement getting back to the form that called for review form
        }
    }
}
