using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace MainController.Controllers
{

    public class IndexController : Controller
    {
        public ViewResult Login()
        {
            return View("Index");
        }
    }
}
