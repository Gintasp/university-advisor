using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IStudySubjectListController
    {
        StudySubjectListView StudySubjectListView { get; set; }
        void LoadStudySubjectData(ListBox listbox);
        void HandleSelectedSubject(string name);
        void HandlePreviousFormButtonClick();
    }
}