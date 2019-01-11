using log4net;
using log4net.Config;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections;
using System.Globalization;
using System.Linq;
using Unity;

namespace EFTest
{
    class Program
    {
        private static readonly ILog log =
            LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {

            XmlConfigurator.Configure();

            log.Info("Hello logging world!");
            //MyContext context = new MyContext();
            //Employee emp = new Employee() { EmpId = 1, EmpName = "Shiju", Address = "Cochin" };
            //context.Employees.Add(emp);
            //context.SaveChanges();

            // Override with the config file, if there is a unity section.
            using (var unity = new UnityContainer())
            {
                //if (UnityConfigurationSection.GetSection("unity") != null)
                //{
                    unity.LoadConfiguration();

                    Console.WriteLine();
                    Console.WriteLine("After loading the config file:");
                    ShowAmount(unity.Resolve<IFormatProvider>(), 1234.56M);
                    ShowListType(unity);
                //}


                Console.ReadLine();
            }
        }

        private static void ShowAmount(IFormatProvider fp, decimal money)
        {
            var fi = fp.GetFormat(typeof(NumberFormatInfo)) as NumberFormatInfo;
            Console.WriteLine(String.Format(fp, "{0:C}", money));
        }

        private static void ShowListType(IUnityContainer unity)
        {
            var reg = unity.Registrations.Single(r => r.RegisteredType == typeof(IList));
            Console.WriteLine("{0} -> {1}",
                reg.RegisteredType.Name, reg.MappedToType.Name);
        }
    }
}
