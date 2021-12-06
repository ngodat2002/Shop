using System.Web;
using System.Web.Optimization;

namespace WAP_T2010A
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //Add css 
            bundles.Add(new StyleBundle("~/AdminPurple/css").Include(
                "~/Content/assets/vendors/mdi/css/materialdesignicons.min.css",
                "~/Content/assets/vendors/css/vendor.bundle.base.css",
                "~/Content/assets/css/style.css"
                ));

            //Add js
            bundles.Add(new ScriptBundle("~/AdminPurple/js").Include(
                "~/Content/assets/vendors/js/vendor.bundle.base.js",
                "~/Content/assets/vendors/chart.js/Chart.min.js",
                "~/Content/assets/js/off-canvas.js",
                "~/Content/assets/js/hoverable-collapse.js",
                "~/Content/assets/js/misc.js",
                "~/Content/assets/js/dashboard.js",
                "~/Content/assets/js/todolist.js"
                ));
        }
    }
}
