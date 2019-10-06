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
        public AddFormView AddFormView { get; set; }

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
            HomeView.UniversityList.Items.Add(uni);
            AddFormView.Close();
        }
        public void LoadUniversityList()
        {
            List<University> unis = DB.Instance.Universities.ToList();
            HomeView.UniversityList.Items.Clear();
            unis.ForEach(uni => HomeView.UniversityList.Items.Add(uni));
        }
        public void HandleUniversitySelect(University uni)
        {
            HomeView.Hide();
            UniversityView = new UniversityView(new UniversityController(uni));
            UniversityView.ShowDialog();
        }
        public void HandleSearchBoxChange()
        {
            if (!string.IsNullOrEmpty(HomeView.SearchBox.Text))
            {
                List<University> unis = DB.Instance.Universities.ToList();
                HomeView.UniversityList.Items.Clear();
                foreach (University uni in unis)
                {
                    if (uni.Title.ToLower().Contains(HomeView.SearchBox.Text.ToLower()))
                    {
                        HomeView.UniversityList.Items.Add(uni); 
                    }
                }
            }
            else LoadUniversityList();
        }
    }
}
