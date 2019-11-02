using System.Web.Optimization;

namespace Advisor
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Script bundles
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Assets/js/lib/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Assets/js/lib/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Assets/js/lib/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Assets/js/lib/bootstrap.js"));

            // Style bundles
            bundles.Add(new StyleBundle("~/bundles/css").Include(
                  "~/Assets/css/lib/bootstrap.css",
                  "~/Assets/css/lib/bootstrap-theme.css",
                  "~/Assets/css/universityList.css",
                  "~/Assets/css/layout.css",
                  "~/Assets/css/comparison.css"
            ));
        }
    }
}
