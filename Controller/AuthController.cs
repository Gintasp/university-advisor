using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using Advisor.View;
using Advisor.Model;
using Advisor.Validator;
using System;

namespace Advisor.Controller
{
    public class AuthController
    {
        string UniversityName;
        string FacultyName;
        public AuthController(
            LoginFormView loginFormView,
            SignupFormView signupFormView,
            WhatUniversityView whatUniversityView,
            IndividualUniversityView individualUniversityView,
            FacultiesListView facultiesListView,
            IndividualFacultyView individualFacultyView,
            List<User> users,
            LoginDataValidator loginDataValidator,
            SignupDataValidator signupDataValidator
        ) {
            LoginFormView = loginFormView;
            SignupFormView = signupFormView;
            WhatUniversityView = whatUniversityView;
            FacultiesListView = facultiesListView;
            IndividualFacultyView = individualFacultyView;
            LoginDataValidator = loginDataValidator;
            SignupDataValidator = signupDataValidator;
            IndividualUniversityView = individualUniversityView;
            Users = users;
        }


        public SignupDataValidator SignupDataValidator { get; set; }
        public LoginDataValidator LoginDataValidator { get; set; }
        public LoginFormView LoginFormView { get; set; }
        public WhatUniversityView WhatUniversityView { get; set; }
        public IndividualUniversityView IndividualUniversityView { get; set; }
        public FacultiesListView FacultiesListView { get; set; }
        public IndividualFacultyView IndividualFacultyView { get; set; }
        public List<User> Users { get; set; }

        public SignupFormView SignupFormView { get; set; }

        public bool AuthenticateUser(string email, string password)
        {
            foreach (User userFromList in Users)
            {
                if (userFromList.Email.Equals(email) && userFromList.Password.Equals(password)) return true;
            }

            return false;
        }

        public void LoadViews()
        {
            LoginFormView.AuthController = this;
            SignupFormView.AuthController = this;
            WhatUniversityView.AuthController = this;
            IndividualUniversityView.AuthController = this;
            FacultiesListView.AuthController = this;
            IndividualFacultyView.AuthController = this;
        }

        public void CloseLoginView()
        {
            LoginFormView.Close();
        }

        public void CloseSignupView()
        {
            SignupFormView.Close();
            LoginFormView.Show();
        }

        public void HandleSignupLinkClick()
        {
            LoginFormView.Hide();
            SignupFormView.ShowDialog();
        }

        public bool HandleLogin (string email, string password)
        {
            if (!LoginDataValidator.Validate(email, password)) return false;
            if (AuthenticateUser(email, password) == true)
            {
                LoginFormView.Hide();
                WhatUniversityView.ShowDialog();
            }
            return false;
        }

        public bool HandleSignup (User user, string passConfirm)
        {
            if (!SignupDataValidator.Validate(user, passConfirm))
            {
                MessageBox.Show(SignupDataValidator.GetSignupDataVadilatorErrorMessage());
                return false;
            }

            File.AppendAllLines(
                Directory.GetCurrentDirectory().ToString() + "\\data.txt",
                new string[] { user.Email, user.Name, user.Password }
            );
            Users.Add(user);
            SignupFormView.Hide();
            LoginFormView.Show();

            return true;
        }
        public void HandleAddUniversityClick()
        {
            MessageBox.Show(";))");
        }
        public void LoadUniversityList(ListBox listBox)
        {
            //laikinai
            listBox.Items.Clear();
            listBox.Items.Add("University");
            listBox.Items.Add("University1");


            //add data from database
        }
        public void HandleSelectedUniversity(string name)
        {
            WhatUniversityView.Hide();
            UniversityName = name;
            IndividualUniversityView.ShowDialog();
        }
        public void HandleLoadIndividualUniversityView(Label label)
        {
            label.Text = UniversityName;
        }
        public void LoadPreviousFormIndividualUniversityView()
        {
            IndividualUniversityView.Hide();
            WhatUniversityView.Show();
        }
        public void HandleFacultiesClicked()
        {
            IndividualUniversityView.Hide();
            FacultiesListView.ShowDialog();
        }
        public void LoadFacultiesList(ListBox listBox)
        {
            //laikinai
            listBox.Items.Clear();
            listBox.Items.Add("Faculty");
            listBox.Items.Add("Faculty1");


            //add data from database
        }
        public void HandleSelectedFaculty(string name)
        {
            FacultiesListView.Hide();
            FacultyName = name;
            IndividualFacultyView.ShowDialog();
        }
        public void LoadPreviousFormFacultiesListView()
        {
            FacultiesListView.Hide();
            IndividualUniversityView.Show();
        }
        public void HandleLoadIndividualFacultyView(Label label)
        {
            label.Text = FacultyName;
        }
        public void LoadPreviousFormIndividualFacultyView()
        {
            IndividualFacultyView.Hide();
            FacultiesListView.Show();
        }
    }
}
