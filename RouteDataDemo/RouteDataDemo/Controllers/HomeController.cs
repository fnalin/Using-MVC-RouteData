using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RouteDataDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            dadosRota();
            return View();
        }

        private void dadosRota()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"] ?? "nulo";
            ViewBag.Rota = string.Format("Controller: {0} | Action: {1} | ID: {2}", controller, action, id);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            dadosRota();
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            dadosRota();
            return View();
        }
    }
}