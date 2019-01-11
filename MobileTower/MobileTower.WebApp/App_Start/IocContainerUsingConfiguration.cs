using Microsoft.Practices.Unity.Configuration;
using System.Web.Mvc;
using Unity;

namespace MobileTower.WebApp.App_Start
{
    public static class IocContainerUsingConfiguration
    {
        public static void ConfigureUnityContainer()
        {
            IUnityContainer container = new UnityContainer();

            container.LoadConfiguration();

            DependencyResolver.SetResolver(new DemoUnityDependencyResolver(container));
        }
    }
}