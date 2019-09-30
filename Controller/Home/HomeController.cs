using System.Windows.Forms;
using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;

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

        public void LoadUniversityList()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            HomeView.UniversityList.Items.Clear();
            foreach(University uni in unis)
            {
                HomeView.UniversityList.Items.Add(uni);
            }
        }

        public void HandleUniversitySelect(University uni)
        {
            HomeView.Hide();
            UniversityView = new UniversityView(UniversityController, uni);
            UniversityView.ShowDialog();
        }
    }
}
