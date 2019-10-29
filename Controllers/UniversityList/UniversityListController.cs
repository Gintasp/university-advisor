using Advisor.Models;
using System;
using System.Data.Entity;
using System.Web.Mvc;

namespace Advisor.Controllers
{
    public class UniversityListController : Controller, IUniversityListController
    {
        [Route("universityList")]
        public ActionResult UniversityList()
        {
            ViewBag.universities = LoadUniversityList();
            return View();
        }
        public DbSet<University> LoadUniversityList()
        {
            var unis = DB.Instance.Universities;
            return unis;
        }
        public void HandleAddUniversityClick()
        {
            //AddFormView = new AddFormView();
            //AddFormView.AddButtonClicked += HandleAddNewUniversity;
            //AddFormView.TitleLabel.Text = "Add new university";
            //AddFormView.ShowDialog();
        }
        public void HandleAddNewUniversity(object sender, EventArgs e)
        {
            //University uni = new University() {
            //    Title = AddFormView.TitleInput.Text,
            //    Description = AddFormView.DescriptionInput.Text
            //};
            //DB.Instance.Universities.Add(uni);
            //DB.Instance.SaveChanges();
            //HomeView.UniversityList.Items.Add(uni);
            //AddFormView.Close();
        }
        public void HandleUniversitySelect(University uni)
        {
            //HomeView.Hide();
            //UniversityView = new UniversityView(new UniversityController(uni));
            //UniversityView.ShowDialog();
        }
        public void HandleSearchBoxChange()
        {
            //if (!string.IsNullOrEmpty(HomeView.SearchBox.Text))
            //{
            //    List<University> unis = DB.Instance.Universities.ToList();
            //    HomeView.UniversityList.Items.Clear();
            //    foreach (University uni in unis)
            //    {
            //        if (uni.Title.ToLower().Contains(HomeView.SearchBox.Text.ToLower()))
            //        {
            //            HomeView.UniversityList.Items.Add(uni); 
            //        }
            //    }
            //}
            //else LoadUniversityList();
        }
    }
}
