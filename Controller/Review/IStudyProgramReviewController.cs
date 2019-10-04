using Advisor.View;

namespace Advisor.Controller
{
    public interface IStudyProgramReviewController : IReviewController
    {
        StudyProgramReviewView StudyProgramReviewView { get; set; }
    }
}
