using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BSUIR.Chepurok.EducationEpam.UI.CoreHelpers
{
  public static class UrlExtensions
  {
    public static string ImagePath(this UrlHelper helper, string imageFileName)
    {
      return helper.Content(string.Format("{0}/{1}", ConfigurationManager.AppSettings["ImagesBasePath"], imageFileName));
    }
  }
}