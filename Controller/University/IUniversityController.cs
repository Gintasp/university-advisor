using Advisor.Model;
using Advisor.View;
using System;

namespace Advisor.Controller
{
    public interface IUniversityController
    {
        UniversityView UniversityView { get; set; }
        void HandlePreviousButtonClick();
        void LoadData();
        void HandleFacultySelect(Faculty faculty);
        void HandleAddFaculty(object sender, EventArgs e);
        void HandleAddFacultyClick();
    }
}