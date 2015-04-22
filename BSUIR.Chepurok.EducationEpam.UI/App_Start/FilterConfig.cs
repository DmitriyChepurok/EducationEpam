using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.UI
{
  public class FilterConfig
  {
    public static void RegisterGlobalFilters(GlobalFilterCollection filters)
    {
      filters.Add(new HandleErrorAttribute());
    }
  }
}
