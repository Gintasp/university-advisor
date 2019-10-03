using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Advisor.Controller
{
    public class UniversityController : IUniversityController
    {
        public UniversityView UniversityView { get; set; }
        public FacultyView FacultyView { get; set; }
        public IFacultyController FacultyController { get; set; }
        public HomeView HomeView { get; set; }
        public AddFormView AddFormView { get; set; }

        public UniversityController(IFacultyController facultyController)
        {
            FacultyController = facultyController;
        }
        public void HandlePreviousButtonClick()
        {
            UniversityView.Hide();
            HomeView = new HomeView(new HomeController(this));
            HomeView.ShowDialog();
        }
        public void LoadFacultyData(University uni)
        {
            UniversityView.Faculties.Items.Clear();
            List<Faculty> faculties = DB.Instance.Faculties.Where(f => f.University.Id == uni.Id).ToList();
            foreach (Faculty faculty in faculties)
            {
                UniversityView.Faculties.Items.Add(faculty);
            }
        }
        public void HandleFacultySelect(Faculty faculty, University uni)
        {
            FacultyView = new FacultyView(FacultyController, faculty, uni);
            UniversityView.Hide();
            FacultyView.ShowDialog();
        }

        public void HandleAddFacultyClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddFaculty;
            AddFormView.TitleLabel.Text = "Add new faculty";
            AddFormView.ShowDialog();
        }

        public void HandleAddFaculty(object sender, EventArgs e)
        {
            Faculty fac = new Faculty()
            {
                Title = AddFormView.TitleInput.Text,
                Description = AddFormView.DescriptionInput.Text,
                University = UniversityView.University
            };
            DB.Instance.Faculties.Add(fac);
            DB.Instance.SaveChanges();
            UniversityView.Faculties.Items.Add(fac);
            AddFormView.Close();
        }
    }
}
