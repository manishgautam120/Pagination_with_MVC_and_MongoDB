using System.Web;
using System.Web.Mvc;

namespace Pagination_with_MVC_and_MongoDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
