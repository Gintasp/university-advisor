using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class UniversityController : IUniversityController
    {
        public UniversityView UniversityView { get; set; }
        public FacultyListView FacultiesListView { get; set; }
        public University University { get; set; }
        public IFacultyListController FacultyListController { get; set; }
        public HomeView HomeView { get; set; }

        public UniversityController(IFacultyListController facultyListController)
        {
            FacultyListController = facultyListController;
        }

        public void HandleFacultiesClick()
        {
            UniversityView.Hide();
            FacultiesListView = new FacultyListView(FacultyListController, University);
            FacultiesListView.ShowDialog();
        }

        public void HandlePreviousButtonClick()
        {
            UniversityView.Hide();
            HomeView.ShowDialog();
        }
    }
}
