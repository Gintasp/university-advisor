using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;

namespace Advisor.Controller
{
    public class HomeController : IHomeController
    {
        public HomeView HomeView { get; set; }
        public UniversityView UniversityView { get; set; }
        public IUniversityController UniversityController { get; set; }

        public HomeController(IUniversityController universityController)
        {
            UniversityController = universityController;
        }

        public void HandleAddUniversityClick()
        {
            //TODO: Handle add university click
        }

        public void LoadUniversityList(ListBox listBox)
        {
            //TODO: Load universities to listbox from DB
            listBox.Items.Clear();
            string exampleUni = "Vilnius University";
            listBox.Items.Add(exampleUni);
        }

        public void HandleUniversitySelect(string universityName)
        {
            //TODO: Filter universities by supplied parameter and pass University to the view below.
            HomeView.Hide();
            University uni = new University();
            uni.Title = "Vilnius University";
            UniversityView = new UniversityView(UniversityController, uni);
            UniversityView.ShowDialog();
        }
    }
}
