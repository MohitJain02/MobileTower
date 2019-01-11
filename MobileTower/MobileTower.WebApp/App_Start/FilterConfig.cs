using MobileTower.WebApp.App_Start;
using System.Web.Mvc;

namespace MobileTower.WebApp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
