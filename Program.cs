using System;
using System.Windows.Forms;
using Ninject;
using Advisor.DependencyInjection;
using Advisor.View;

namespace Advisor
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var kernel = new StandardKernel(new Bindings());
            var loginFormView = kernel.Get<LoginFormView>();
            Application.Run(loginFormView);
        }
    }
}
