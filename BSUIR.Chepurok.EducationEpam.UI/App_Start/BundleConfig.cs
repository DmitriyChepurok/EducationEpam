using System.Web;
using System.Web.Optimization;

namespace BSUIR.Chepurok.EducationEpam.UI
{
  public class BundleConfig
  {
    // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
    public static void RegisterBundles(BundleCollection bundles)
    {
      bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                  "~/Scripts/jquery-{version}.js"));

      bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                  "~/Scripts/jquery.validate*"));

      // Use the development version of Modernizr to develop with and learn from. Then, when you're
      // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
      bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                  "~/Scripts/modernizr-*"));

      bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

      bundles.Add(new ScriptBundle("~/bundles/education").Include(
                "~/Scripts/js/vendor-core.min.js",
                "~/Scripts/js/vendor-countdown.min.js",
                "~/Scripts/js/vendor-tables.min.js",
                "~/Scripts/js/vendor-forms.min.js",
                "~/Scripts/js/vendor-carousel-slick.min.js",
                "~/Scripts/js/vendor-player.min.js",
                "~/Scripts/js/vendor-charts-flot.min.js",
                "~/Scripts/js/vendor-nestable.min.js",
                "~/Scripts/js/module-essentials.min.js",
                "~/Scripts/js/module-material.min.js",
                "~/Scripts/js/module-layout.min.js",
                "~/Scripts/js/module-sidebar.min.js",
                "~/Scripts/js/module-carousel-slick.min.js",
                "~/Scripts/js/module-player.min.js",
                "~/Scripts/js/module-messages.min.js",
                "~/Scripts/js/module-maps-google.min.js",
                "~/Scripts/js/module-charts-flot.min.js",
                "~/Scripts/js/theme-core.min.js"));

      bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/vendor.css",
                "~/Content/css/education-styles.css",
                "~/Content/css/theme-core.css",
                "~/Content/css/module-essentials.min.css",
                "~/Content/css/module-material.min.css",
                "~/Content/css/module-layout.min.css",
                "~/Content/css/module-sidebar.min.css",
                "~/Content/css/module-sidebar-skins.min.css",
                "~/Content/css/module-navbar.min.css",
                "~/Content/css/module-messages.min.css",
                "~/Content/css/module-carousel-slick.min.css",
                "~/Content/css/module-charts.min.css",
                "~/Content/css/module-maps.min.css",
                "~/Content/css/module-colors-alerts.min.css",
                "~/Content/css/module-colors-background.min.css",
                "~/Content/css/module-colors-buttons.min.css",
                "~/Content/css/module-colors-text.min.css"));
    }
  }
}