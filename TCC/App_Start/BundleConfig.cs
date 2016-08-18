using System.Web;
using System.Web.Optimization;

namespace TCC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/js").Include(
                      "~/Scripts/bootstrap.min.js",
                       "~/Scripts/jquery-ui.min.js",
                       "~/Scripts/bootstrap-datetimepicker.min.js",
                       "~/Scripts/wysihtml5-0.3.0.js",
                      "~/Scripts/prettify.js",
                      "~/Scripts/bootstrap-wysihtml5.min.js",
                      "~/Scripts/jquery.flot.min.js",
                      "~/Scripts/jquery.flot.stack.min.js",
                      "~/Scripts/jquery.flot.pie.min.js",
                      "~/Scripts/jquery.flot.resize.min.js",
                      "~/Scripts/jquery.steps.min.js",
                      "~/Scripts/jquery.knob.js",
                      "~/Scripts/jquery.sparklines.js",
                      "~/Scripts/jquery.slimscroll.min.js",
                      "~/Scripts/jquery.dataTables.min.js",
                      "~/Scripts/jquery.prettyPhoto.js",
                      "~/Scripts/jquery.rateit.min.js",
                      "~/Scripts/moment.min.js",
                      "~/Scripts/fullcalendar.min.js",
                      "~/Scripts/jquery.gritter.min.js",
                      "~/Scripts/custom.notification.js",
                      "~/Scripts/respond.min.js",
                      "~/Scripts/html5shiv.js",
                      "~/Scripts/custom.js",
                      "~/Scripts/respond.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/jquery.gritter.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/less-style.css",
                      "~/Content/style.css",
                      "~/Content/site.css"));
        }
    }
}
