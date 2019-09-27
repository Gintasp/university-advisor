using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class FacultyController : IFacultyController
    {
        public FacultyView FacultyView { get; set; }
        public FacultyListView FacultyListView { get; set; }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyView.Hide();
            FacultyListView.Show();
        }
    }
}
