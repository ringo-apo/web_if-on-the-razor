using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        [HttpPost]
        public ActionResult Send(string value1, string value2)
        {
            ViewData["PostData"] = value1 + "+" + value2 + "=" + (int.Parse(value1) + int.Parse(value2)).ToString();
            ViewData["PostData2"] = (int.Parse(value1) + int.Parse(value2)).ToString();
            return View();
        }
    }
}