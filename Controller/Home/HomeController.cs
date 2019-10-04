using Advisor.Model;
using Advisor.View;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Advisor.Controller
{
    public class HomeController : IHomeController
    {
        public HomeView HomeView { get; set; }
        public UniversityView UniversityView { get; set; }
        public IUniversityController UniversityController { get; set; }
        public AddFormView AddFormView { get; set; }

        public HomeController(IUniversityController universityController)
        {
            UniversityController = universityController;
        }

        public void HandleAddUniversityClick()
        {
            AddFormView = new AddFormView();
            AddFormView.AddButtonClicked += HandleAddNewUniversity;
            AddFormView.TitleLabel.Text = "Add new university";
            AddFormView.ShowDialog();
        }

        public void HandleAddNewUniversity(object sender, EventArgs e)
        {
            University uni = new University() {
                Title = AddFormView.TitleInput.Text,
                Description = AddFormView.DescriptionInput.Text
            };
            DB.Instance.Universities.Add(uni);
            DB.Instance.SaveChanges();
            AddFormView.Close();
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
