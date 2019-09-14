using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Advisor
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            List<string> lines = File.ReadAllLines(Directory.GetCurrentDirectory().ToString() + "\\data.txt").ToList();
            List<User> usersList= new List<User>();
            while (lines.Count > 0)
            {
                usersList.Add(new User(lines.ElementAt(0), lines.ElementAt(1), lines.ElementAt(2)));
                for (int i = 0; i < 3; i++)
                {
                    lines.RemoveAt(0);
                }
            }

            LoginFormView loginFormView = new LoginFormView();
            SignupFormView signupFormView = new SignupFormView();
            AuthController authController = new AuthController(loginFormView, signupFormView, usersList);
            authController.LoadViews();
            loginFormView.ShowDialog();
        }
    }
}
