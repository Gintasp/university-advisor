using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public interface IStudySubjectListController
    {
        StudySubjectListView StudySubjectListView { get; set; }
        void LoadStudySubjectData();
        void HandleSelectedSubject(StudySubject subject);
        void HandlePreviousFormButtonClick();
    }
}