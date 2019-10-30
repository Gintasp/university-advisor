using Advisor.Models;
using System;
using System.Collections.Generic;

namespace Advisor.Controllers
{
    public interface IUniversityListController
    {
        void HandleAddUniversityClick();
        void HandleAddNewUniversity(object sender, EventArgs e);
        List<University> LoadUniversityList();
        void HandleUniversitySelect(University uni);
        void HandleSearchBoxChange();
    }
}
