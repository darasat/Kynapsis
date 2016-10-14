using System.Web;
using System.Web.Optimization;

namespace Kynapsis
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
                      "~/Scripts/respond.js", "~/Scripts/jquery.dcjqaccordion.2.7.js",
                      "~/Scripts/jquery.scrollTo.min.js", "~/Scripts/jquery.nicescroll.js", "~/Scripts/jquery.common - scripts.js",
                      "~/Scripts/moment.min.js", "~/Scripts/jquery.min.js", "~/Scripts/fullcalendar.min.js", "~/Scripts/es.js"));

            bundles.Add(new ScriptBundle("~/bundles/scripts")
           .IncludeDirectory("~/Scripts", "*.js", true));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css", "~/ Content/fullcalendar.css", "~/Content/fullcallendar.print.css",
                      "~/Content/jquery-ui.min.css", "~/Content/style-responsive.css", "~/Content/style.css", "~/Content/to-do.css",
                      "~/Content/font-awesome.css"
                      ));
        }
    }
}
