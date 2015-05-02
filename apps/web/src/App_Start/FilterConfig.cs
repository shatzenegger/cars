using System.Web;
using System.Web.Mvc;

namespace com.shatzenegger.cars.apps.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
