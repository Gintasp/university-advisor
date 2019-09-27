using System.Windows.Forms;
using Advisor.View;

namespace Advisor.Controller
{
    public class HomeController : IHomeController
    {
        public HomeView HomeView { get; set; }

        public void HandleAddUniversityClick()
        {
            MessageBox.Show(";))");
        }

        public void LoadUniversityList(ListBox listBox)
        {
            //TODO: Load universities from DB
        }
    }
}
