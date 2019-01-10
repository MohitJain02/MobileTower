using Microsoft.Practices.Unity.Configuration;
using Unity;

namespace EFTest
{
    public class DataProviderFactory
    {
        private IUnityContainer container { get; set; }
        public DataProviderFactory()
        {
            container = new UnityContainer();

            container.LoadConfiguration(Constants.DataAccessProviderContainer);
            //Run // container.LoadConfiguration(Constants.DataAccessProviderContainer);
            //OR below code
            //UnityConfigurationSection section = (UnityConfigurationSection)ConfigurationManager.GetSection(Constants.Unity);
            //section.Configure(container, Constants.DataAccessProviderContainer);
        }
        public IDataProvider CreateDataProvider()
        {
            return container.Resolve<IDataProvider>();
        }
        public IDataProvider CreateDataProvider(string dataProviderName)
        {
            return container.Resolve<IDataProvider>(dataProviderName);
        }
        private static class Constants
        {
            public const string DataAccessProviderContainer = "DataAccessProvider";
            public const string Unity = "unity";
        }
    }

}
