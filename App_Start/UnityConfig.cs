using Advisor.Controllers;
using Advisor.Services.IO;
using Advisor.Services.Statistics;
using Advisor.Services.Validator;
using System.Web.Mvc;
using Unity;
using Unity.Injection;
using Unity.Mvc5;

namespace Advisor
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            
            // register all your components with the container here
            // it is NOT necessary to register your controllers
            
            container.RegisterType<IStatisticCalculator, StatisticCalculator>();
            container.RegisterType<IStatsBuilder, StatsBuilder>();
            container.RegisterType<IFileManager, FileManager>();
            container.RegisterType<IFileValidator, FileValidator>();
            container.RegisterType<AccountController>(new InjectionConstructor());
            container.RegisterType<ManageController>(new InjectionConstructor());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
