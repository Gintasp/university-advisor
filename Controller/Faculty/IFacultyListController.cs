using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IFacultyListController
    {
        FacultyListView FacultyListView { get; set; }
        void LoadFacultyList( University uni);
        void HandlePreviousButtonClick(University uni);
        void HandleFacultySelect(string faculty, University uni);
    }
}