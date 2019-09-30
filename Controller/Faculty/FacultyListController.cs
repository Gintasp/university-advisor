using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;

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

        public void LoadFacultyList(University uni)
        {
            FacultyListView.FacultiesList.Items.Clear();
            foreach (Faculty faculty in uni.Faculties)
            {
                FacultyListView.FacultiesList.Items.Add(faculty);
            }
        }
        public void HandlePreviousButtonClick(University uni)
        {
            FacultyListView.Hide();
            UniversityView = new UniversityView(new UniversityController(this), uni);
            UniversityView.Show();
        }

        public void HandleFacultySelect(Faculty faculty, University uni)
        {
            FacultyView = new FacultyView(FacultyController, faculty, uni);
            FacultyListView.Hide();
            FacultyView.ShowDialog();
        }
    }
}
