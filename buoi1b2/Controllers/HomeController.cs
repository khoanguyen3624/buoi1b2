using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace buoi1b2.Controllers
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
        public ActionResult baitap1()
        {
            

            return View();
        }
        public ActionResult baitap2()
        {


            return View();
        }
        public ActionResult baitap3()
        {


            return View();
        }
        public ActionResult baitap4()
        {


            return View();
        }
    }
}