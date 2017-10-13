using System.Web.Mvc;

namespace Astra.Backend
{
    internal class FilterConfig
    {
        internal static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}