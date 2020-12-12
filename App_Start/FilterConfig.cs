using System.Web;
using System.Web.Mvc;

namespace www.konnectaapp.co.za
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
