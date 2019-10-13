using Advisor.Model;
using Advisor.View;
using Advisor.View.Comparison;
using System;

namespace Advisor.Controller
{
    public interface IStudyProgramComparisonController
    {
        StudyProgramComparisonView ComparisonView { get; set; }
        StudyProgramView PreviousView { get; set; }
        SelectPopup SelectPopup { get; set; }
        void HandlePreviousFormClick();
        void HandleProgramOneSelectClick();
        void HandleProgramTwoSelectClick();
    }
}
