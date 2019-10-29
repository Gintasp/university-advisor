using Advisor.Models;
using Microsoft.Owin;
using Owin;
using System;
using System.IO;
using System.Linq;

[assembly: OwinStartupAttribute(typeof(Advisor.Startup))]
namespace Advisor
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            string filePath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).FullName + "\\Migrations\\Data\\User.csv";
            var users = DB.Instance.Users.ToList();
            var reviews = File.ReadAllLines(filePath).ToList();
            ConfigureAuth(app);
        }
    }
}
