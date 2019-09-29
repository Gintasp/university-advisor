using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advisor.View;

namespace Advisor.Controller
{
    public interface ITextReviewController
    {
        TextReviewView TextReviewView { get; set; }

        void HandleSubmitReviewButtonClick();
        void HandlePreviousFormLinkClick();
    }
}
