using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Advisor
{
    public class LoginController
    {
        public LoginController (LoginFormView loginFormView, List<User> users) 
        {
            LoginFormView = loginFormView;
            Users = users;
        }

        public LoginFormView LoginFormView { get; set; }

        public List<User> Users { get; set; }

        public bool AuthenticateUser(string email, string password)
        {
            foreach(User userFromList in Users)
            {
                if (userFromList.Email.Equals(email) && userFromList.Password.Equals(password)) return true;
            }

            return false;
        }

        public void LoadView()
        {
            LoginFormView.LoginController = this;
        }

        public void CloseView()
        {
            this.LoginFormView.Close();
        }

        public void HandleLogin(string email, string password)
        {
            if(!(string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)))
            {
                if (this.AuthenticateUser(email, password) == true) MessageBox.Show(";))");
            }
        }
    }
}
