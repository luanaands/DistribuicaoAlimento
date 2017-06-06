using System.Web;
using System.Web.Optimization;

namespace DistribuaAlimento
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*",
                        "~/Scripts/methods_pt.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                            "~/Scripts/bootstrap.min.js",
                            "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/sb-admin-js").Include(
                            "~/Scripts/sb-admin-2.js",
                            "~/Scripts/metisMenu.js",
                            "~/Scripts/toastr.js",
                            "~/Scripts/moment.min.js",
                            "~/Scripts/moment.pt-br.js",
                            "~/Scripts/jquery.maskMoney.min.js",
                            "~/Scripts/bootstrap-datepicker.js",
                            "~/Scripts/custom.js"
                ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/sb-admin-2.css",
                "~/Content/metisMenu.css",
                "~/Content/navbar.css",
                "~/Content/toastr.css",
                "~/Content/custom.css",
                "~/Content/bootstrap-datepicker.css"));
        }
    }
}
