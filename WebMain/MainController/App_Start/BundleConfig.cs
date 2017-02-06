using System.Web.Optimization;
using System.Web.Routing;

namespace MainController.App_Start
{
    internal class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //RegisterJsBundles(bundles);
            //RegisterCssBundles(bundles);          

            BundleTable.EnableOptimizations = false;
#if !DEBUG
            BundleTable.EnableOptimizations = true;
#endif
        }

        public static void RegisterJsBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/scripts/allJs").Include( ));


            bundles.Add(new ScriptBundle("~/scripts/RWallJs").Include( ));

            bundles.Add(new ScriptBundle("~/scripts/allJsWithoutGoogleAnalytics").Include(   ));
         
        }

        public static void RegisterCssBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/styles/client-lib/all").Include(
                "~/styles/client-lib/bootstrap.min.css",
                "~/styles/client-lib/font-awesome.min.css"));
        }
    }
}
