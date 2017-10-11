using System.Web;
using System.Web.Optimization;

namespace OTIS_POC
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.UseCdn = true;

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/3rdpartyjs").Include(
                        "~/Scripts/sidebar-menu.js",
                        "~/Scripts/custom.js",
                        "~/Scripts/Chart.bundle.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css",
                      "~/Content/sidebar-menu.css"));

            bundles.Add(new StyleBundle("~/Content/3rdpartycss").Include(
                                            "~/Content/sidebar-menu.css"));

            bundles.Add(new StyleBundle("~/Content/fontawesome",
                "https://maxcdn.bootstrapcdn.com/font-awesome/4.6.3/css/font-awesome.min.css"));

            bundles.Add(new StyleBundle("~/Content/fonts",
                "https://fonts.googleapis.com/css?family=Raleway|Source+Sans+Pro"));
        



        }
    }
}
