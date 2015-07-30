using System.Web;
using System.Web.Mvc;

namespace PandyIT.HMS.UI.MVCFrontEnd
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}