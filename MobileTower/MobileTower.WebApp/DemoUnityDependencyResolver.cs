using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Unity;

namespace MobileTower.WebApp
{
    public class DemoUnityDependencyResolver : IDependencyResolver
    {
        private IUnityContainer _container;

        public DemoUnityDependencyResolver(IUnityContainer container)
        {
            _container = container;
        }
        public object GetService(Type serviceType)
        {
            if (typeof(IController).IsAssignableFrom(serviceType))
            {
                return _container.Resolve(serviceType);
            }

            return null;
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _container.ResolveAll(serviceType);
        }
    }
}