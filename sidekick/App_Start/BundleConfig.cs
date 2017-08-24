using System.Web;
using System.Web.Optimization;

namespace sidekick
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

            //theme dependencies:    
            bundles.Add(new ScriptBundle("~/bundles/JS_Dependencies").Include(
                    "~/Scripts/jquery-2.1.4.min.js",
                    "~/Scripts/bootstrap.min.js",
                    "~/Scripts/jquery.superslides.min.js",
                    "~/Scripts/jquery.mb.YTPlayer.min.js",
                    "~/Scripts/imagesloaded.pkgd.js",
                    "~/Scripts/isotope.pkgd.min.js",
                    "~/Scripts/jquery.magnific-popup.min.js",
                    "~/Scripts/owl.carousel.min.js",
                    "~/Scripts/jquery.fitvids.js",
                    "~/Scripts/jqBootstrapValidation.js",
                    "~/Scripts/appear.js",
                    "~/Scripts/smoothscroll.js",
                    "~/Scripts/submenu-fix.js",
                    "~/Scripts/contact.js",
                    "~/Scripts/jquery-1.102.js",
                    "~/Scripts/custom.js"));

            bundles.Add(new ScriptBundle("~/Scripts/chosen/chosen.js").Include(
                    "~/Scripts/chosen/chosen.jquery.js",
                    "~/Scripts/chosen/chosen.jquery.min.js",
                    "~/Scripts/chosen/chosen.proto.js"));

            bundles.Add(new ScriptBundle("~/Scripts/angular.js").Include(
                "~/Scripts/angular/angular.js"));

            //bundles.Add(new ScriptBundle("~/sidekick/core.js").Include(
            //    "~/Scripts/sidekick.js",
            //    "~/Scripts/sidekick/sidekick.module.js"));
        }
    }
}
