using System.Windows.Forms;
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
            FacultyListView = new FacultyListView(new FacultyListController(this), uni);
            FacultyListView.Show();
        }

        public void LoadStudyProgramData(ListView listView)
        {
            //TODO: Load items from DB
            listView.Items.Clear();
            listView.Items.Add("Programu sistemos");
        }
    }
}
