using System.Web;
using System.Web.Mvc;

namespace FIT5032_WEEK2_MyCodeSnippet
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
