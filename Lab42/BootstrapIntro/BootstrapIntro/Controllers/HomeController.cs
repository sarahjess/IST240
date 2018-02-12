using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace BootstrapIntro.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Workflow Reimagined";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "NHTI - SAJ Enterprises";

            return View();
        }

        public ActionResult CalcApp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CalcApp(string valueA, string valueB, string radSelect) //Under Construction
        {
            Decimal total = 0;
            var totalMsg = "";


            switch (radSelect)
            {
                case "add":
                    total = valueA.AsDecimal() + valueB.AsDecimal();
                    break;

                case "subtract":
                    total = valueA.AsDecimal() - valueB.AsDecimal();
                    break;

                case "multiply":
                    total = valueA.AsDecimal() * valueB.AsDecimal();
                    break;

                case "divide":
                    total = valueA.AsDecimal() / valueB.AsDecimal();
                    break;

            }

            //Display Result
            totalMsg = "Result: " + total;
            

            return View("CalcApp", (object)totalMsg);
        }
    }
}