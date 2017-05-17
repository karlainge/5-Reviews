using System.Web;
using System.Web.Mvc;

namespace _5_Stars_Reviews
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
