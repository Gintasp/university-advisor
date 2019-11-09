using Advisor.Services.IO;
using Advisor.Services.Statistics;
using Advisor.Services.Validator;
using System.Web.Mvc;
using Unity;
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
            container.RegisterType<IFileUploader, FileUploader>();
            container.RegisterType<IFileValidator, FileValidator>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
