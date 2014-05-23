using System.Web.Optimization;

namespace VM_Tipset_2.App_Start
{
    public static class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/vm-js-bundle").Include(
                        "~/Scripts/bootstrap.js",
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/modernizr-{version}.js"));
            /*
            var firstOnSiteScriptBundle = new ScriptBundle("~/bundles/firstonsite").Include(
                "~/Scripts/firstonsite.js",
                "~/Scripts/source/SignIn.js");
            firstOnSiteScriptBundle.Transforms.Add(new JsMinify());
            bundles.Add(firstOnSiteScriptBundle);
            */

            bundles.Add(new StyleBundle("~/bundles/vm-css-bundle").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap-theme.css"));

            /*
            var firstOnSiteCssBundle =
                new StyleBundle("~/Content/css/firstonsite").Include("~/Content/css/firstonsite.css");
            firstOnSiteCssBundle.Transforms.Add(new CssMinify());
            bundles.Add(firstOnSiteCssBundle);
            */

            BundleTable.EnableOptimizations = true;
        }
    }
}