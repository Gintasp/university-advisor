using Advisor.Models;
using System;
using System.Data.Entity;

namespace Advisor.Controllers
{
    public interface IUniversityListController
    {
        void HandleAddUniversityClick();
        void HandleAddNewUniversity(object sender, EventArgs e);
        DbSet<University> LoadUniversityList();
        void HandleUniversitySelect(University uni);
        void HandleSearchBoxChange();
    }
}
