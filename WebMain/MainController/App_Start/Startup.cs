using MainController.App_Start;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Routing;

[assembly: OwinStartup(typeof(Startup))]
namespace MainController.App_Start
{
    public class Startup
    {
        public void OnApplicationStart()
        {
            ViewEngines.Engines.Clear();
            ViewEngines.Engines.Add(new CSharpRazorViewEngine(false));
            RouteConfig.RegisterRoutes(RouteTable.Routes, false);
        }
    }
}
