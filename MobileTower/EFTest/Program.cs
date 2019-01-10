using log4net;
using log4net.Config;
using System;

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

            Console.ReadLine();
        }
    }
}
