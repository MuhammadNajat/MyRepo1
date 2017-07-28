using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using log4net;

namespace TryMVC1.Controllers
{
    public class HomeController : Controller
    {

        private static readonly ILog log = LogManager.GetLogger("DemoLog");

        public ActionResult Index()
        {

            try
            {
                int x = 1000000;
                for (int i = -10; i <= 10; i++)
                    x /= i;
            }

            catch(Exception ex)
            {
                log.Debug("Error Occured in Index", ex);
            }

            //log.Debug("HeLLO DEBUGGING!!!");

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}