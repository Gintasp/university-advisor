using Advisor.Model;
using System;

namespace Advisor.Controllers
{
    public interface IUniversityController
    {
        void HandlePreviousButtonClick();
        void LoadData();
        void HandleFacultySelect(Faculty faculty);
        void HandleAddFaculty(object sender, EventArgs e);
        void HandleAddFacultyClick();
        void HandleComparisonButtonClick();
    }
}