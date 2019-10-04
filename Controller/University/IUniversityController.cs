using Advisor.Model;
using Advisor.View;
using System;

namespace Advisor.Controller
{
    public interface IUniversityController
    {
        UniversityView UniversityView { get; set; }
        void HandlePreviousButtonClick();
        void LoadFacultyData(University uni);
        void HandleFacultySelect(Faculty faculty, University uni);
        void HandleAddFaculty(object sender, EventArgs e);
        void HandleAddFacultyClick();
    }
}