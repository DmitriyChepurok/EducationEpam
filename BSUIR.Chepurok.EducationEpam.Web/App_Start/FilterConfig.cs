using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.Web
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
