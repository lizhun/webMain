using System.Diagnostics.Contracts;
using System.Text;
using System.Web.Mvc;
using System.Web;
using System.Web.Routing;

namespace MainController.App_Start
{
    internal class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes, bool isSupportMvcAreas)
        {
            Contract.Assert(routes != null);

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            if (isSupportMvcAreas)
            {
                // route for areas
                AreaRegistration.RegisterAllAreas();
            }

            RegisterDefaultRoute(routes);
            //LogAllRoutes(RouteTable.Routes);
        }

        private static void RegisterDefaultRoute(RouteCollection routes)
        {
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}",
                defaults: new { controller = "Index", action = "Login", id = UrlParameter.Optional },
                namespaces: new string[] {
                    "MainController.Controllers"
                });
        }

        private static void LogAllRoutes(RouteCollection routeCollection)
        {
            var messageStringBuilder = new StringBuilder();
            messageStringBuilder.AppendLine("All Routes:");

            foreach (RouteBase routeBase in routeCollection)
            {
                var route = routeBase as Route;
                if (route != null)
                {
                    messageStringBuilder.AppendLine(route.Url);
                }
            }
        }
    }
}
