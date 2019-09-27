using Advisor.View;
using System.Windows.Forms;

namespace Advisor.Controller
{
    public interface IHomeController
    {
        HomeView HomeView { get; set; }
        void HandleAddUniversityClick();
        void LoadUniversityList(ListBox listBox);
    }
}
