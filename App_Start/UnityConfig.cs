using Advisor.Services.Statistics;
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
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}
