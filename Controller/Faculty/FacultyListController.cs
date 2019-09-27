using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class FacultyListController : IFacultyListController
    {
        public FacultyListView FacultyListView { get; set; }
        public UniversityView UniversityView { get; set; }
        public FacultyView FacultyView { get; set; }
        public IFacultyController FacultyController { get; set; }
        public University University { get; set; }

        public FacultyListController(IFacultyController facultyController)
        {
            FacultyController = facultyController;
        }

        public void LoadFacultyList(ListBox listbox, University uni)
        {
            //TODO: Fetch all faculties of given university and add them to the listbox.
            listbox.Items.Clear();
            listbox.Items.Add("MIF");
        }

        public void HandlePreviousButtonClick(University uni)
        {
            FacultyListView.Hide();
            UniversityView = new UniversityView(new UniversityController(this), uni);
            UniversityView.Show();
        }

        public void HandleFacultySelect(string faculty, University uni)
        {
            //TODO: Find Faculty in DB by given parameter and pass to the view below.
            Faculty exampleFaculty = new Faculty();
            exampleFaculty.Title = "MIF";
            FacultyView = new FacultyView(FacultyController, exampleFaculty, uni);
            FacultyListView.Hide();
            FacultyView.ShowDialog();
        }
    }
}
