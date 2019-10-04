using Advisor.Model;
using Advisor.View;
using System;

namespace Advisor.Controller
{
    public interface IHomeController
    {
        HomeView HomeView { get; set; }
        void HandleAddUniversityClick();
        void HandleAddNewUniversity(object sender, EventArgs e);
        void LoadUniversityList();
        void HandleUniversitySelect(University uni);
        void HandleSearchBoxChange();
    }
}
