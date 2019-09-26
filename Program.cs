using System;
using System.Windows.Forms;
using Advisor.Controller;
using Ninject;
using Advisor.DependencyInjection;

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

            var kernel = new StandardKernel(new Bindings());
            AuthController authController = kernel.Get<AuthController>();

            authController.LoadViews();
            authController.LoginFormView.ShowDialog();
        }
    }
}
