using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;

namespace Advisor.Controller
{
    public class UniversityController : IUniversityController
    {
        public UniversityView UniversityView { get; set; }
        public FacultyView FacultyView { get; set; }
        public IFacultyController FacultyController { get; set; }
        public HomeView HomeView { get; set; }

        public UniversityController(IFacultyController facultyController)
        {
            FacultyController = facultyController;
        }
        public void HandlePreviousButtonClick()
        {
            UniversityView.Hide();
            HomeView = new HomeView(new HomeController(this));
            HomeView.ShowDialog();
        }
        public void LoadFacultyData(University uni)
        {
            UniversityView.Faculties.Items.Clear();
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == uni.Id).ToList();
            foreach (Faculty faculty in faculties)
            {
                UniversityView.Faculties.Items.Add(faculty);
            }
        }
        public void HandleFacultySelect(Faculty faculty, University uni)
        {
            FacultyView = new FacultyView(FacultyController, faculty, uni);
            UniversityView.Hide();
            FacultyView.ShowDialog();
        }
    }
}
