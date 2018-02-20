using System.Web.Optimization;

namespace AngularJSMVC
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/AwesomeAngularMVCApp")
                    .IncludeDirectory("~/Scripts/Controllers", "*.js")
                    .Include("~/Scripts/AwesomeAngularMVCApp.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;
        }
    }
}
