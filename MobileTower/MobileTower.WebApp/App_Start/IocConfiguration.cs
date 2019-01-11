using MobileTower.WebApp.Services;
using System.Web.Mvc;
using Unity;

namespace MobileTower.WebApp.App_Start
{
    public static class IocConfiguration
    {
        public static void ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            RegisterServices(container);

            DependencyResolver.SetResolver(new DemoUnityDependencyResolver(container));

        }

        public static void RegisterServices(IUnityContainer container)
        {
            container.RegisterType<IPriceCalculator, PriceCalculator>();

        }
    }
}