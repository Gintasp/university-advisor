using Advisor.Model;
using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IFacultyController
    {
        FacultyView FacultyView { get; set; }
        void HandlePreviousButtonClick(University uni);
        void LoadStudyProgramData(ListView listView);
    }
}