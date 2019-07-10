using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab_10_mvc_database.Controllers
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

        public List<String> myList = new List<string>()
        { "a","b","c"};


        public ActionResult alex_page()
        {
            ViewBag.Message = "My personal page";
            return View("alex_page", myList);
        }
    }
}