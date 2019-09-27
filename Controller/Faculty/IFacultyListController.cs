using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IFacultyListController
    {
        FacultyListView FacultyListView { get; set; }
        void LoadFacultyList(ListBox listbox, University uni);
        void HandlePreviousButtonClick();
        void HandleFacultySelect(string faculty);
    }
}