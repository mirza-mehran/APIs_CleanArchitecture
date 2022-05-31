using System.Web;
using System.Web.Mvc;

namespace APIs_CleanArchitecture
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
