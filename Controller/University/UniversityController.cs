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

        public void HandleFacultiesClick(University uni)
        {
            UniversityView.Hide();
            FacultiesListView = new FacultyListView(FacultyListController, uni);
            FacultiesListView.ShowDialog();
        }

        public void HandlePreviousButtonClick()
        {
            UniversityView.Hide();
            HomeView = new HomeView(new HomeController(this));
            HomeView.ShowDialog();
        }
    }
}
